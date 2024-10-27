using KAF.UI.Service;
using KAF.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

        public LoginWindow(IContainerProvider containerProvider, Window currentWindow, IUserService userService, IRegionManager regionManager, IDialogService dialogService)
        {
            InitializeComponent();

            _containerProvider = containerProvider;
            _currentWindow = currentWindow;
            _userService = userService;
            _regionManager = regionManager;
            _dialogService = dialogService;

            loginViewModel = new LoginViewModel(containerProvider, currentWindow, userService, dialogService, regionManager);
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
