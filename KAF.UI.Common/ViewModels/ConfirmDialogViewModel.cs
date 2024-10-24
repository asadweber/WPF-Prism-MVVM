using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Common.ViewModels
{
    public class ConfirmDialogViewModel : BindableBase, IDialogAware
    {
        public string Title => "Confirm";

        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public DelegateCommand CloseCommand { get; private set; }
        public DelegateCommand CancelCommand { get; private set; }

                                        
        DialogCloseListener IDialogAware.RequestClose => new DialogCloseListener();

        DialogCloseListener RequestClose;

        public ConfirmDialogViewModel()
        {
            CloseCommand = new DelegateCommand(OnClose);
            CancelCommand = new DelegateCommand(OnCancel);

        }

        private void OnCancel()
        {
           RequestClose.Invoke(new DialogResult(ButtonResult.Cancel));
        }

        private void OnClose()
        {
            RequestClose.Invoke(new DialogResult(ButtonResult.OK));
        }

        public bool CanCloseDialog() => true;
        public void OnDialogClosed() { }
        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
