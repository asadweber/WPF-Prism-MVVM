using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Common.Model
{
    public class Department : BaseModel
    {
        private long _departmentId;
        private string _departmentName;

        public long DepartmentId { get => _departmentId; set => SetProperty(ref _departmentId, value); }
        public string DepartmentName { get => _departmentName; set => SetProperty(ref _departmentName, value); }



    }
}
