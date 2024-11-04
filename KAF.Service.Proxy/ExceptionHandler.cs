using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KAF.Service.Proxy
{
    public class ExceptionHandler : IExceptionHandler
    {

        public void Handle(Exception exception)
        {
            // Log the exception, display a message, etc.
            MessageBox.Show($"An error occurred: {exception.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            // You can also log to a file or a logging service here
        }
    }
}
