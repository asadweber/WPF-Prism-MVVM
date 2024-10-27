using KAF.UI.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAF.UI.Service.Interface
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();

        Department GetDepartment(int id);
    }
}
