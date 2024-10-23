using KAF.UI.Common.Model;
using KAF.UI.Module.View;
using KAF.UI.Service;
using KAF.UI.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace KAF.UI.Module.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IUserService _userService;

        private readonly IRegionManager _regionManager;

        public ObservableCollection<MenuItemModel> MenuItems { get; private set; }
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
                Header = "General",
                Command = new DelegateCommand(()=>ExecuteEmptyCommand(string.Empty)),
                SubItems = new List<MenuItemModel>
                {
                    new MenuItemModel { Header = "Department", Command = new DelegateCommand(()=>ExecuteNew("DepartmentView")) },
                }
            },
        };
        }

        private void ExecuteEmptyCommand(string ViewName) { /* Logic for File */ }
        public void ExecuteNew(string ViewName) { 
                 _regionManager.RequestNavigate("formContentRegion",ViewName);
         }
        
    }
}
