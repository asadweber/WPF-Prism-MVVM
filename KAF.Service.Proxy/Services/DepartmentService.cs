using KAF.Service.Proxy.Client;
using KAF.UI.Service.Interface;

namespace KAF.UI.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        public Department GetDepartment(int id)
        {
            Department department = new Department();
            return department;
        }

        public async Task<List<Department>> GetDepartments()
        {
            // Create a list of departments with sample data
            //Let assume data load take some time
            await Task.Delay(300);
            List<Department> list = new List<Department>
                    {
                        new Department { DepartmentCode = 1, DepartmentName = "HR" },
                        new Department { DepartmentCode = 2, DepartmentName = "IT" },
                        new Department { DepartmentCode = 3, DepartmentName = "Finance" }
                    };

            return list;
        }

        Department IDepartmentService.GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<Department>> IDepartmentService.GetDepartments()
        {
            throw new NotImplementedException();
        }
    }
}
