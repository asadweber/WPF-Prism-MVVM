using AutoMapper;
using KAF.Service.Proxy.Client;
using KAF.UI.Common.Helper;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http;

namespace KAF.Service.Proxy
{
    public class ServiceModule : IModule
    {
        private readonly IRegionManager _regionManager;
        public IConfiguration SettingConfiguration { get; private set; }

        public ServiceModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // Register the view in a specific region (e.g., MenuRegion)
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register AutoMapper with profiles
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>(); // Add the AutoMapper profile here
            });

            // Register the mapper as a singleton
            containerRegistry.RegisterInstance(config.CreateMapper());

            // Load configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            SettingConfiguration = builder.Build();
            // Register IConfiguration for dependency injection
            containerRegistry.RegisterInstance<IConfiguration>(SettingConfiguration);
            // Read BaseUrl from configuration
            var apiSettings = new ApiSettings();
            SettingConfiguration.GetSection("ApiSettings").Bind(apiSettings);


            // Register the KafApiClient with a base URL
            containerRegistry.Register<IDepartmentApiClient>(sp => new DepartmentApiClient(apiSettings.BaseUrl, sp.Resolve<HttpClient>()));




        }
    }
}
