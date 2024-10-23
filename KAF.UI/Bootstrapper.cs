using KAF.UI;
using KAF.UI.Module;
using KAF.UI.Module.View;
using KAF.UI.Service;
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

    //protected override void OnInitialized()
    //{
    //    base.OnInitialized();
    //    // Configure regions after showing the main window
    //    ConfigureRegions();
    //}

    //private void ConfigureRegions()
    //{
    //    // Resolve the IRegionManager
    //    var regionManager = Container.Resolve<IRegionManager>();
    //    // Register views with the region
    //    //regionManager.RegisterViewWithRegion("MenuRegion", typeof(MenuView));
    //    //regionManager.RegisterViewWithRegion("formContentRegion", typeof(HomeView));
    //}

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        //Register All Service
        containerRegistry.RegisterSingleton<IUserService, UserService>();

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