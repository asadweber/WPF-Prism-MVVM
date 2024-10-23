using KAF.UI.Common.View;
using KAF.UI.Common.ViewModels;
using KAF.UI.Module.View;
using KAF.UI.Module.ViewModels;
using Prism.Ioc;

namespace KAF.UI.Module
{
    public class MenuModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenuModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // Register the view in a specific region (e.g., MenuRegion)
            _regionManager.RegisterViewWithRegion("MenuRegion", typeof(MenuView));
            _regionManager.RegisterViewWithRegion("formContentRegion", typeof(HomeView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any services or view models related to the Menu module
            containerRegistry.RegisterForNavigation<HomeView,HomeViewModel>();
            containerRegistry.RegisterForNavigation<MenuView,MenuViewModel>();

           // Register the UserControl and its ViewModel as a dialog
            containerRegistry.RegisterDialog<DialogView,DialogViewModel>();

        }
    }
}
