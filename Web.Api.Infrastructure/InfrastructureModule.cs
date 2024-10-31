using Autofac;
using Web.Core.Frame.Interfaces.Gateways.Repositories;
using Web.Core.Frame.Interfaces.Services;
using Web.Api.Infrastructure.Auth;
using Web.Api.Infrastructure.Interfaces;
using Web.Api.Infrastructure.Logging;
using Module = Autofac.Module;
using Web.Api.Infrastructure.Services;
using Web.Core.Frame.Interfaces;



namespace Web.Api.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<JwtTokenHandler>().As<IJwtTokenHandler>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<JwtTokenValidator>().As<IJwtTokenValidator>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<SecCapFillerFromJWTClaim>().As<ISecCapFillerFromJWTClaim>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<HttpClientHR>().As<IHttpClientHR>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<dataHashingHandler>().As<IdataHashing>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());

            builder.RegisterType<Logger>().As<ILogger>().SingleInstance();

            builder.RegisterType<TokenFactory>().As<ITokenFactory>().SingleInstance();
            builder.RegisterType<EmailSender>().As<IEmailSender>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<DigitalNotificationSender>().As<IDigitalNotificationSender>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<PaciCivilIDInformationSender>().As<IPaciCivilIDInformationSender>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());
            builder.RegisterType<PaciMainCivilIDInformationSender>().As<IPaciMainCivilIDInformationSender>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());


            builder.RegisterType<StringCompression>().As<IStringCompression>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());

            builder.RegisterType<HttpClientPACIAuth>().As<IHttpClientPACIAuth>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());

            builder.RegisterType<FileUploadClient>().As<IFileUploadClient>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());


            builder.RegisterType<NotificationService>().As<INotificationService>().SingleInstance().FindConstructorsWith(new InternalConstructorFinder());



        }
    }
}
