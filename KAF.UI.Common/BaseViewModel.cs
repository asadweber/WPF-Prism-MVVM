using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KAF.UI.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, INotifyDataErrorInfo
    {
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        private bool isEnabled;
        public bool IsEnabled
        {
            get => isEnabled;
            set => SetProperty(ref isEnabled, value);
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }


        private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

        // INotifyDataErrorInfo implementation
        public bool HasErrors => _errors.Any();
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return propertyName != null && _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        // Method to validate a property using DataAnnotations
        public void ValidateProperty(object value, string propertyName)
        {
            // Clear previous errors
            _errors.Remove(propertyName);

            var validationContext = new ValidationContext(this) { MemberName = propertyName };
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateProperty(value, validationContext, validationResults);

            if (validationResults.Any())
            {
                // Store errors for the property
                _errors[propertyName] = validationResults.Select(r => r.ErrorMessage).ToList();
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }
    }
}