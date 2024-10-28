
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace KAF.UI.Common.Helper
{

    public static class NumericTextBoxBehavior
    {
        public static bool GetIsNumericOnly(TextBox textBox) => (bool)textBox.GetValue(IsNumericOnlyProperty);

        public static void SetIsNumericOnly(TextBox textBox, bool value) => textBox.SetValue(IsNumericOnlyProperty, value);

        public static readonly DependencyProperty IsNumericOnlyProperty =
            DependencyProperty.RegisterAttached(
                "IsNumericOnly", typeof(bool), typeof(NumericTextBoxBehavior),
                new PropertyMetadata(false, OnIsNumericOnlyChanged));

        private static void OnIsNumericOnlyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                if ((bool)e.NewValue)
                    textBox.PreviewTextInput += TextBox_PreviewTextInput;
                else
                    textBox.PreviewTextInput -= TextBox_PreviewTextInput;
            }
        }

        private static void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }


}