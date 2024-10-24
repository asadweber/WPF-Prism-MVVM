using KAF.UI.Common.View;
using KAF.UI.Common.ViewModels;
using KAF.UI.Module.View;
using KAF.UI.Module.ViewModels;
using KAF.UI.Service;
using Prism.Ioc;
using Prism.Navigation.Regions;

namespace KAF.UI.Module
{
    public class AppModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public AppModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // Register the view in a specific region (e.g., MenuRegion)
            _regionManager.RegisterViewWithRegion(RegionNameConfig.MenuRegionName, typeof(MenuView));
            _regionManager.RegisterViewWithRegion(RegionNameConfig.ContentRegionName, typeof(HomeView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
             //Register All Service
             containerRegistry.RegisterSingleton<IUserService, UserService>();

            // Register the UserControl and its ViewModel as a dialog
            containerRegistry.RegisterDialog<DialogView, DialogViewModel>();
            containerRegistry.RegisterDialog<ConfirmDialogView, ConfirmDialogViewModel>();


            // Register any services or view models related to the Menu module
            containerRegistry.RegisterForNavigation<DepartmentView, DepartmentViewModel>();
            containerRegistry.RegisterForNavigation<HomeView, HomeViewModel>();
            containerRegistry.RegisterForNavigation<MenuView, MenuViewModel>();

        }
    }
}
