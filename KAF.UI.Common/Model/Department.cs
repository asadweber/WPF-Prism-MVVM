using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KAF.UI.Common.Model
{
    public class Department : BaseModel, INotifyDataErrorInfo
    {
        private long? _departmentCode;
        private string _departmentName;


        [Required(ErrorMessage = "Department Code is required.")]
        public long? DepartmentCode
        {
            get => _departmentCode; set
            {
                if (_departmentCode != value)
                {
                    _departmentCode = value;
                    SetProperty(ref _departmentCode, value); ;
                    ValidateProperty(nameof(DepartmentCode));
                }
            }
        }


        [Required(ErrorMessage = "Department name is required.")]
        public string DepartmentName
        {
            get => _departmentName;
            set
            {
                if (_departmentName != value)
                {
                    _departmentName = value;
                    SetProperty(ref _departmentName, value); ;
                    ValidateProperty(nameof(DepartmentName));
                }
            }

        }


        private readonly Dictionary<string, List<string>> _errors = new();

        public bool HasErrors => _errors.Count > 0;

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {
            if (_errors.ContainsKey(propertyName))
            {
                return _errors[propertyName];
            }
            return null;
        }

        public void ValidateProperty(string propertyName)
        {
            var context = new ValidationContext(this) { MemberName = propertyName };
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateProperty(GetType().GetProperty(propertyName)?.GetValue(this), context, validationResults);

            // Clear previous errors
            if (_errors.ContainsKey(propertyName))
            {
                _errors.Remove(propertyName);
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }

            // Add new errors if any
            foreach (var validationResult in validationResults)
            {
                if (!_errors.ContainsKey(propertyName))
                {
                    _errors[propertyName] = new List<string>();
                }
                _errors[propertyName].Add(validationResult.ErrorMessage);
            }

            // Notify about the errors
            if (_errors.ContainsKey(propertyName))
            {
                ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }
    }
}
