using System.Windows;
using System.Windows.Controls;

namespace KAF.UI.Common.Helper
{
    public static class PasswordBoxBehavior
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.RegisterAttached("Password",
                                                typeof(string),
                                                typeof(PasswordBoxBehavior),
                                                new FrameworkPropertyMetadata(string.Empty, OnPasswordChanged));

        public static string GetPassword(DependencyObject obj)
        {
            return (string)obj.GetValue(PasswordProperty);
        }

        public static void SetPassword(DependencyObject obj, string value)
        {
            obj.SetValue(PasswordProperty, value);
        }

        private static void OnPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox passwordBox)
            {
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

                if (!string.IsNullOrEmpty(passwordBox.Password))
                {
                    // Prevents password change event from firing
                    passwordBox.Password = string.Empty;
                }

                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;

                // Set the password from the binding when it changes
                passwordBox.Password = e.NewValue as string;
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                // Update the attached property when the password changes
                SetPassword(passwordBox, passwordBox.Password);
            }
        }
    }
}