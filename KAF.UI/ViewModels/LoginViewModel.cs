using KAF.Service.Proxy.Client;
using KAF.Service.Proxy.Dto;
using KAF.UI.Common;
using KAF.UI.Common.View;
using KAF.UI.Views;
using System.Windows;

namespace KAF.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        // Command Property
        public DelegateCommand<UserDto> LoginCommand { get; private set; }

        //DI
        private readonly IContainerProvider _containerProvider;
        private readonly Window _currentWindow;
        private readonly IRegionManager _regionManager;


        private readonly IAuthApiClient authApiClient;



        private UserDto _currentUser;
        public UserDto CurrentUser { get => _currentUser; set => SetProperty(ref _currentUser, value); }


        private readonly IDialogService _dialogService;


        public LoginViewModel(IContainerProvider containerProvider, Window currentWindow, IDialogService dialogService, IRegionManager regionManager, IAuthApiClient authApiClient)
        {
            Title = "User Login";
            _containerProvider = containerProvider;
            _currentWindow = currentWindow;


            _currentUser = new UserDto();

#if DEBUG
            _currentUser.UserName = "admin";
            _currentUser.Password = "admin";
#endif

            LoginCommand = new DelegateCommand<UserDto>(ExecuteLoginCommand, CanExecuteLogin);

            _dialogService = dialogService;
            _regionManager = regionManager;
            this.authApiClient = authApiClient;
        }

        // Logic to determine whether the command can be executed (can enable/disable button)
        private bool CanExecuteLogin(UserDto login)
        {
            // You can add any condition here, but let's keep it always true for simplicity
            return true;
        }

        private async void ExecuteLoginCommand(UserDto login)
        {

            //Apply Login Logic
            // Validate user credentials (this is just an example)

            var loginResponse = await authApiClient.LoginAsync(new LoginRequest()
            {
                UserName = login.UserName,
                Password = login.Password
            });
            if (loginResponse.Success)
            {

                //Add other Data
                //_userService.CurrentUser = loginResponse.AccessToken;
                ApplicationState.CurrentUser = new AccessTokenDto
                {
                    Token = loginResponse.AccessToken.Token,
                    RefreshToken = loginResponse.AccessToken.RefreshToken,
                    ExpiresIn = loginResponse.AccessToken.ExpiresIn,
                };


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
                        { "message", "Invalid Login." }
                    };

                _dialogService.ShowDialog(typeof(DialogView).Name, parameters, r =>
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
