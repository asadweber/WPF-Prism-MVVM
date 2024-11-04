using KAF.Service.Proxy.Dto;
using KAF.UI.Common;
using KAF.UI.Module.View;
using Prism.Commands;
using Prism.Navigation.Regions;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KAF.UI.Module.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {

        private readonly IRegionManager _regionManager;

        public ObservableCollection<MenuItemModelDto> MenuItems { get; private set; }
       
        private MenuItemModelDto _selectedItem;
        public MenuItemModelDto SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }

        public MenuViewModel(IRegionManager regionManager)
        {
                MenuItems = new ObservableCollection<MenuItemModelDto>();
            GenerateMockMenu();
            _regionManager = regionManager;
        }

        private void GenerateMockMenu()
        {
            MenuItems = new ObservableCollection<MenuItemModelDto>
        {
                new MenuItemModelDto
            {
                Header = "Home",
                Command = new DelegateCommand(()=>ExecuteNew(typeof(HomeView).Name)),
                SubItems = new List<MenuItemModelDto> ()

            },
            new MenuItemModelDto
            {
                Header = "General",
                Command = new DelegateCommand(()=>ExecuteEmptyCommand(string.Empty)),
                SubItems = new List<MenuItemModelDto>
                {

                    new MenuItemModelDto { Header = "Department", Command = new DelegateCommand(()=>ExecuteNew(typeof(DepartmentView).Name)) },
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
