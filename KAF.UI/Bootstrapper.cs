using KAF.Service.Proxy.Client;
using KAF.UI;
using KAF.UI.Common.Helper;
using KAF.UI.Module;
using KAF.UI.ViewModels;
using KAF.UI.Views;
using Microsoft.Extensions.Configuration;
using Prism.Ioc;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Windows;

public class Bootstrapper : PrismBootstrapper
{
    public IConfiguration Configuration { get; private set; }


    protected override DependencyObject CreateShell()
    {
        // Resolve the main window (shell)
        return Container.Resolve<LoginWindow>();
    }
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // Load configuration
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        Configuration = builder.Build();

        // Register IConfiguration for dependency injection
        containerRegistry.RegisterInstance<IConfiguration>(Configuration);
        containerRegistry.RegisterSingleton<IEventAggregator, EventAggregator>();
       
        //Register All Service
        // Register HttpClient (but we will configure it later)
        containerRegistry.RegisterInstance(new HttpClient());

        // Read BaseUrl from configuration
        var apiSettings = new ApiSettings();
        Configuration.GetSection("ApiSettings").Bind(apiSettings);


        // Register the KafApiClient with a base URL
        containerRegistry.Register<IAuthApiClient>(sp =>new AuthApiClient(apiSettings.BaseUrl, sp.Resolve<HttpClient>()));
        containerRegistry.Register<IDepartmentApiClient>(sp =>new DepartmentApiClient(apiSettings.BaseUrl, sp.Resolve<HttpClient>()));




        // Register the custom window that will host the UserControl dialog
        containerRegistry.RegisterDialogWindow<AppDialogWindow>();

        // Register All shells Window
        containerRegistry.RegisterForNavigation<LoginWindow, LoginViewModel>();
        containerRegistry.RegisterForNavigation<MasterWindow, MasterViewModel>();
    }
    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<AppModule>();
    }
}