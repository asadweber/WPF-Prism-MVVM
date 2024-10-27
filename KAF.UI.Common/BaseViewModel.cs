using KAF.UI.Common.Model;
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
        public void ValidateProperty(object type)
        {
            _errors.Clear();  // Clear existing errors

            // Create ValidationContext for the entire Department object
            var validationContext = new ValidationContext(type);
            var validationResults = new List<ValidationResult>();

            // Validate the entire object based on DataAnnotations
            Validator.TryValidateObject(type, validationContext, validationResults, validateAllProperties: true);

            // Populate _errors dictionary with validation results
            foreach (var validationResult in validationResults)
            {
                foreach (var memberName in validationResult.MemberNames)
                {
                    if (!_errors.ContainsKey(memberName))
                    {
                        _errors[memberName] = new List<string>();
                    }
                    _errors[memberName].Add(validationResult.ErrorMessage);
                }
            }

            // Notify the UI that errors have changed
            foreach (var memberName in _errors.Keys)
            {
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(memberName));
            }
        }
    }
}