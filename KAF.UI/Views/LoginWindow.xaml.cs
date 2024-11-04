using KAF.Service.Proxy.Client;
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
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;

        private readonly IAuthApiClient _authApiClient;

        public LoginWindow(IContainerProvider containerProvider, Window currentWindow,
          IRegionManager regionManager, IDialogService dialogService, IAuthApiClient authApiClient)
        {
            InitializeComponent();

            _containerProvider = containerProvider;
            _currentWindow = currentWindow;
            _regionManager = regionManager;
            _dialogService = dialogService;
            _authApiClient = authApiClient;

            loginViewModel = new LoginViewModel(containerProvider, currentWindow, dialogService, regionManager,_authApiClient);
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
