using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.Service.Proxy.Dto
{
    public class DepartmentDto : BaseModel
    {
        private long? _departmentCode;
        private string _departmentName;


        [Required(ErrorMessage = "Department Code is required.")]
        public long? DepartmentCode
        {
            get => _departmentCode;

            set
            {
                SetProperty(ref _departmentCode, value);
                RaisePropertyChanged(nameof(DepartmentCode));
                ValidateProperty(value, nameof(DepartmentCode));
            }

        }


        [Required(ErrorMessage = "Department name is required.")]
        public string DepartmentName
        {
            get => _departmentName;
            set
            {

                SetProperty(ref _departmentName, value);
                RaisePropertyChanged(nameof(DepartmentName));
                ValidateProperty(value, nameof(DepartmentName));
            }

        }


    }
}
