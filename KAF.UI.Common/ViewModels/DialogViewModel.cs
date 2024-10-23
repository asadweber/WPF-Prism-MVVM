using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Common.ViewModels
{
    public class DialogViewModel : BindableBase, IDialogAware
    {
        public string Title => "My Dialog";

        public event Action<IDialogResult> RequestClose;

        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public DelegateCommand CloseCommand { get; private set; }

        DialogCloseListener IDialogAware.RequestClose => throw new NotImplementedException();

        public DialogViewModel()
        {
            CloseCommand = new DelegateCommand(OnClose);
        }

        private void OnClose()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
        }

        public bool CanCloseDialog() => true;
        public void OnDialogClosed() { }
        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>("message");
        }
    }
}
