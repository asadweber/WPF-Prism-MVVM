using KAF.UI.Common.Model;
using KAF.UI.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        public Department GetDepartment(int id)
        {
            Department department = new Department();
            return department;
        }

        public List<Department> GetDepartments()
        {
            List<Department> list = new List<Department>();
            return list;
        }
    }
}
