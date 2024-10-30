
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using CLL.Localization;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Infrastructure.Auth;
using Web.Api.Infrastructure.Providers;
using Web.Core.Frame.CustomAuthorization;
using Web.Core.Frame.CustomIdentityManagers;
using Web.Core.Frame.CustomStores;
using WebApi.Extensions;

namespace WebApi.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MvcInstaller : IInstaller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="_configuration"></param>
        public void InstallServices(IServiceCollection services, IConfiguration _configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            AddLocalizationConfigurations(services);
            services.AddResponseCaching();
            services.AddHttpClient();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", builder => builder.WithOrigins("https://kafpacitst.kuwaitarmy.gov.kw", "http://kafpacitst.kuwaitarmy.gov.kw", "http://localhost:44318", "https://localhost:4431").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder
                            .AllowCredentials()
                            .WithOrigins("https://localhost:5000", "https://localhost", "https://localhost:44318", "http://localhost:44318", "http://localhost:5000", "http://localhost")
                            .SetIsOriginAllowedToAllowWildcardSubdomains()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    });
            });

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
                //options.Filters.Add<ValidationFilter>();
            })
            .AddFluentValidation(mvcConfiguration => mvcConfiguration.RegisterValidatorsFromAssemblyContaining<Startup>())
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddIdentity<owin_userEntity, IdentityRole>(options => {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            })
               .AddErrorDescriber<CusIdentityErrorDescriber>()
               .AddDefaultTokenProviders()
               .AddUserManager<ApplicationUserManager<owin_userEntity>>()
               .AddSignInManager<ApplicationSignInManager<owin_userEntity>>();

            services.AddSingleton<IUserStore<owin_userEntity>, CustomUserStore>();
            services.AddSingleton<IRoleStore<IdentityRole>, CustomRoleStore>();
            services.AddTransient<ApiSecurityFillerAttribute>();



            services.Configure<AuthSettings>(_configuration.GetSection(nameof(AuthSettings)));
            var authSettings = _configuration.GetSection(nameof(AuthSettings)).Get<AuthSettings>();
            var ftpSettings = _configuration.GetSection(nameof(FtpSettings)).Get<FtpSettings>();
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(authSettings.SecretKey));
            var jwtIssuerOptions = _configuration.GetSection(nameof(JwtIssuerOptions)).Get<JwtIssuerOptions>();

            services.Configure<JwtIssuerOptions>(options=>
            {
                options.Issuer = jwtIssuerOptions.Issuer;
                options.Audience = jwtIssuerOptions.Audience;
                options.ValidFor = jwtIssuerOptions.ValidFor;
                options.SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            });


            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.ClaimsIssuer = jwtIssuerOptions.Issuer;
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = jwtIssuerOptions.Issuer,
                        
                        ValidateAudience = true,
                        ValidAudience = jwtIssuerOptions.Audience,

                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = signingKey,

                        RequireExpirationTime = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero
                    };
                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Token-Expired", "true");
                            }
                            return Task.CompletedTask;
                        },
                        OnMessageReceived = context =>
                        {
                            return Task.CompletedTask;
                        }
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiPolicy", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.Requirements.Add(new IsApprovedRequirement());
                    policy.Requirements.Add(new IsLockedRequirement());
                    policy.Requirements.Add(new IsRoleActionRequirement());
                    policy.AuthenticationSchemes = new List<string> { JwtBearerDefaults.AuthenticationScheme };
                });
                options.AddPolicy("allowAllApiPolicy", policy =>
				{
					policy.RequireAuthenticatedUser();
					policy.AuthenticationSchemes = new List<string> { JwtBearerDefaults.AuthenticationScheme };
				}); 
            });

            services.AddSingleton<IAuthorizationHandler, IsApprovedReqHandler>();
            services.AddSingleton<IAuthorizationHandler, IsLockedReqHandler>();
            services.AddSingleton<IAuthorizationHandler, IsRoleActionReqHandler>();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        }

        private static void AddLocalizationConfigurations(IServiceCollection services)
        {
            services.AddSingleton<LocalizeService>();
            services.AddLocalization(options => options.ResourcesPath = "Localization");
            services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = new List<CultureInfo>
                        {
                            new CultureInfo("en-US"),
                            new CultureInfo("ar-KW")
                        };
                    options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "ar-KW");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                    var providerQuery = new LocalizationQueryProvider
                    {
                        QueryParameterName = "ui_locales"
                    };
                    options.RequestCultureProviders.Insert(0, providerQuery);
                });
        }
    }
}
