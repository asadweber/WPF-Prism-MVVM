using KAF.Service.Proxy.Clients;
using KAF.UI;
using KAF.UI.Module;
using KAF.UI.Service.Interface;
using KAF.UI.Service.Services;
using KAF.UI.ViewModels;
using KAF.UI.Views;
using System.Windows;

public class Bootstrapper : PrismBootstrapper
{
    protected override DependencyObject CreateShell()
    {
        // Resolve the main window (shell)
        return Container.Resolve<LoginWindow>();
    }
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

        containerRegistry.RegisterSingleton<IEventAggregator, EventAggregator>();


        //Register All Service
        containerRegistry.RegisterSingleton<IUserService, UserService>();

        containerRegistry.RegisterScoped<IKafApiClient, KafApiClient>();


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