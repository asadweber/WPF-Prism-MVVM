using BDO.Core.Base;
using System.ComponentModel.DataAnnotations;

namespace BDO.Model
{
    public class Department:BaseEntity
    {
        private long? _departmentCode;
        private string _departmentName;

        [Required(ErrorMessage = "Department Code is required.")]
        public long? DepartmentCode
        {
            get => _departmentCode;
            set => _departmentCode = value;

        }


        [Required(ErrorMessage = "Department name is required.")]
        public string DepartmentName
        {
            get => _departmentName;
            set => _departmentName = value;

        }

    }
}
