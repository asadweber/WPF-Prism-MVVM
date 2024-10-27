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
    public class Department : BaseModel
    {
        private long? _departmentCode;
        private string _departmentName;


        [Required(ErrorMessage = "Department Code is required.")]
        public long? DepartmentCode
        {
            get => _departmentCode; 
            
            set  => SetProperty(ref _departmentCode, value);
        }


        [Required(ErrorMessage = "Department name is required.")]
        public string DepartmentName
        {
            get => _departmentName;
            set => SetProperty(ref _departmentName, value);

        }


   
    }
}
