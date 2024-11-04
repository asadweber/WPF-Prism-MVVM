using KAF.Service.Proxy.Client;
using KAF.UI.Common.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KAF.UI.Common.ExceptionHandler
{
    public class ExceptionHandler : IExceptionHandler
    {

        private readonly IDialogService _dialogService;

        public ExceptionHandler(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }
        public void Handle(Exception exception)
        {

            var parameters = new DialogParameters
                        {
                            {
                                "message", exception.Message
                            }
                        };
            _dialogService.ShowDialog(typeof(DialogView).Name, parameters, r =>
             {
             });
        }

        public void Handle(ApiException exception)
        {
            var parameters = new DialogParameters
                        {
                            {
                                "message", exception.Response.ToString()
                            }
                        };
            _dialogService.ShowDialog(typeof(DialogView).Name, parameters, r =>
             {
             });
        }
    }
}
