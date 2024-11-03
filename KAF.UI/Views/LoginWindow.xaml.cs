using KAF.Service.Proxy.Clients;
using KAF.UI.Service.Interface;
using KAF.UI.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace KAF.UI.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private StringBuilder _passwordBuilder = new StringBuilder();
        public LoginViewModel loginViewModel { get; set; }

        private readonly IContainerProvider _containerProvider;
        private readonly Window _currentWindow;
        private readonly IUserService _userService;
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        private readonly IKafApiClient _apiClient;

        public LoginWindow(IContainerProvider containerProvider, Window currentWindow, IUserService userService, IRegionManager regionManager, IDialogService dialogService, IKafApiClient apiClient)
        {
            InitializeComponent();

            _containerProvider = containerProvider;
            _currentWindow = currentWindow;
            _userService = userService;
            _regionManager = regionManager;
            _dialogService = dialogService;
             _apiClient= apiClient;
            loginViewModel = new LoginViewModel(containerProvider, currentWindow, userService, dialogService, regionManager,_apiClient);
            DataContext = loginViewModel;
        }


        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as PasswordBox;
            loginViewModel.CurrentUser.Password = passwordBox.Password; // Update the ViewModel property
        }
    }
}
