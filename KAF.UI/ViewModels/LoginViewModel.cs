using KAF.UI.Common.Model;
using KAF.UI.Service;
using KAF.UI.Views;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KAF.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        // Command Property
        public DelegateCommand<User> LoginCommand { get; private set; }

        //DI
        private readonly IContainerProvider _containerProvider;
        private readonly Window _currentWindow;
        private readonly IUserService _userService;
        private readonly IRegionManager _regionManager;


        private User _currentUser;
        public User CurrentUser { get => _currentUser; set => SetProperty(ref _currentUser, value); }


        private readonly IDialogService _dialogService;


        public LoginViewModel(IContainerProvider containerProvider, Window currentWindow, IUserService userService, IDialogService dialogService, IRegionManager regionManager)
        {
            Title = "User Login";
            _containerProvider = containerProvider;
            _currentWindow = currentWindow;


            _currentUser = new User();

#if DEBUG
            _currentUser.UserName = "admin";
            _currentUser.Password = "admin";
#endif

            LoginCommand = new DelegateCommand<User>(ExecuteLoginCommand, CanExecuteLogin);
            _userService = userService;

            _dialogService = dialogService;
            _regionManager = regionManager;
        }

        // Logic to determine whether the command can be executed (can enable/disable button)
        private bool CanExecuteLogin(User login)
        {
            // You can add any condition here, but let's keep it always true for simplicity
            return true;
        }

        private void ExecuteLoginCommand(User login)
        {

            //Apply Login Logic
            // Validate user credentials (this is just an example)
            if (login.UserName == "admin" && login.Password == "admin") // Replace with real validation
            {
                //Add other Data
                _userService.CurrentUser = login;

                Application.Current.Dispatcher.Invoke(() =>
                   {
                       // Close the login window
                       var loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();
                       loginWindow?.Hide();

                       // Create and show the master window
                       var masterWindow = _containerProvider.Resolve<MasterWindow>();       
                        
                       // Ensure the RegionManager is associated with MainShell
                        RegionManager.SetRegionManager(masterWindow, _regionManager);

                       // Optionally, you can set the master window as the application main window
                       Application.Current.MainWindow = masterWindow;
                       Application.Current.MainWindow.Show();
                   });
            }
            else
            {
                var parameters = new DialogParameters
                    {
                        { "message", "This is a dialog message." }
                    };

                _dialogService.ShowDialog("DialogView", parameters, r =>
                {
                    if (r.Result == ButtonResult.OK)
                    {
                        // Handle OK result
                    }
                    else if (r.Result == ButtonResult.Cancel)
                    {
                        // Handle Cancel result
                    }
                });
            }


        }


    }
}
