using KAF.UI.Common.Model;
using KAF.UI.Service;
using KAF.UI.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace KAF.UI.Module.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        private readonly IUserService _userService;

        public ObservableCollection<MenuItemModel> MenuItems { get; private set; }
        public MenuViewModel(IUserService userService)
        {
            _userService = userService;
            MenuItems = new ObservableCollection<MenuItemModel>();
            GenerateMockMenu();
        }

        private void GenerateMockMenu()
        {
            MenuItems = new ObservableCollection<MenuItemModel>
        {
            new MenuItemModel
            {
                Header = "General",
                Command = new DelegateCommand(() => ExecuteFileCommand()),
                SubItems = new List<MenuItemModel>
                {
                    new MenuItemModel { Header = "New", Command = new DelegateCommand(ExecuteNew) },
                }
            },
            //new MenuItemModel
            //{
            //    Header = "Edit",
            //    Command = new DelegateCommand(() => ExecuteEditCommand()),
            //    SubItems = new List<MenuItemModel>
            //    {
            //        new MenuItemModel { Header = "Cut", Command = new DelegateCommand(ExecuteCut) },
            //        new MenuItemModel { Header = "Copy", Command = new DelegateCommand(ExecuteCopy) },
            //        new MenuItemModel { Header = "Paste", Command = new DelegateCommand(ExecutePaste) }
            //    }
            //}
        };
        }

        private void ExecuteFileCommand() { /* Logic for File */ }
        private void ExecuteNew() { 
            System.Windows.MessageBox.Show("New clicked");             
         }
        private void ExecuteOpen() { System.Windows.MessageBox.Show("Open clicked"); }
        private void ExecuteSave() { System.Windows.MessageBox.Show("Save clicked"); }

        private void ExecuteEditCommand() { /* Logic for Edit */ }
        private void ExecuteCut() { System.Windows.MessageBox.Show("Cut clicked"); }
        private void ExecuteCopy() { System.Windows.MessageBox.Show("Copy clicked"); }
        private void ExecutePaste() { System.Windows.MessageBox.Show("Paste clicked"); }
    }
}
