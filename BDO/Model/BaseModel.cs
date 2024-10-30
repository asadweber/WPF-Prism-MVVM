using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BDO.Model
{
    public class BaseModel : BindableBase, INotifyDataErrorInfo
    {


        private readonly Dictionary<string, List<string>> _errors = new();
        public bool HasErrors => _errors.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            return _errors.ContainsKey(propertyName) ? _errors[propertyName] : null;
        }

        public void ValidateProperty(object value, string propertyName)
        {
            _errors.Remove(propertyName);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(this) { MemberName = propertyName };
            if (!Validator.TryValidateProperty(value, context, results))
            {
                _errors[propertyName] = results.Select(r => r.ErrorMessage).ToList();
            }

            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public void ValidateAllProperties()
        {
            foreach (var property in GetType().GetProperties())
            {
                var value = property.GetValue(this);
                ValidateProperty(value, property.Name);
            }
        }
    }
}
