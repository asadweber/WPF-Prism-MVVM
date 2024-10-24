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

        public LoginWindow()
        {
            InitializeComponent();
        }




        private void PasswordTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Get the TextBox reference
            var textBox = sender as TextBox;

            // Append the new character to the actual password (stored in the StringBuilder)
            _passwordBuilder.Append(e.Text);

            // Prevent the character from being directly shown in the TextBox
            e.Handled = true;

            // Show the masked password (replace all characters with *)
            textBox.Text = new string('*', _passwordBuilder.Length);

            // Move the caret to the end of the text to keep typing consistent
            textBox.CaretIndex = textBox.Text.Length;
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Update the bound Password property whenever the password is changed
            var textBox = sender as TextBox;
            if (textBox != null && DataContext is LoginViewModel viewModel)
            {
                viewModel.CurrentUser.Password = _passwordBuilder.ToString();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
