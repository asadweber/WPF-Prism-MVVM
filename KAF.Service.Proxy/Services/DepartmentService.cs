using BDO.Model;
using KAF.Service.Proxy.Client;
using KAF.UI.Service.Interface;
using System.Net.Http;
using Department = BDO.Model.Department;

namespace KAF.UI.Service.Services
{
    public class DepartmentService : IDepartmentService
    {

        private readonly HttpClient _httpClient;
        private readonly IUserService _userService;
        private readonly IDepartmentApiClient _departmentApiClient;


        public DepartmentService(HttpClient httpClient, IDepartmentApiClient departmentApiClient, IUserService userService)
        {
            this._departmentApiClient = departmentApiClient;
            _httpClient = httpClient;
            _userService = userService;
        }

        public Department GetDepartment(int id)
        {
            Department department = new Department();
            return department;
        }

        public async Task<List<Department>> GetDepartments()
        {
            // Create a list of departments with sample data
            //Let assume data load take some time
            //await Task.Delay(300);

            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _userService.CurrentUser.Token);

            var data = await _departmentApiClient.GetAllDepartmentAsync();




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

       
    }
}
