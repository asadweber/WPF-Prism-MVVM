using BDO.Model;
using KAF.UI.Common;
using KAF.UI.Module.View;
using KAF.UI.Service.Interface;
using System.Collections.ObjectModel;

namespace KAF.UI.Module.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IUserService _userService;

        private readonly IRegionManager _regionManager;

        public ObservableCollection<MenuItemModel> MenuItems { get; private set; }
       
        private MenuItemModel _selectedItem;
        public MenuItemModel SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        public MenuViewModel(IUserService userService, IRegionManager regionManager)
        {
            _userService = userService;
            MenuItems = new ObservableCollection<MenuItemModel>();
            GenerateMockMenu();
            _regionManager = regionManager;
        }

        private void GenerateMockMenu()
        {
            MenuItems = new ObservableCollection<MenuItemModel>
        {
                new MenuItemModel
            {
                Header = "Home",
                Command = new DelegateCommand(()=>ExecuteNew(typeof(HomeView).Name)),
                SubItems = new List<MenuItemModel> ()

            },
            new MenuItemModel
            {
                Header = "General",
                Command = new DelegateCommand(()=>ExecuteEmptyCommand(string.Empty)),
                SubItems = new List<MenuItemModel>
                {

                    new MenuItemModel { Header = "Department", Command = new DelegateCommand(()=>ExecuteNew(typeof(DepartmentView).Name)) },
                }
            },
        };
        }

        private void ExecuteEmptyCommand(string ViewName) { /* Logic for File */ }
        public void ExecuteNew(string ViewName)
        {
            _regionManager.RequestNavigate(RegionNameConfig.ContentRegionName, ViewName);
        }

    }
}
