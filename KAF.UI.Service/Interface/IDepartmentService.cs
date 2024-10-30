using BDO.Model;

namespace KAF.UI.Service.Interface
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetDepartments();

        Department GetDepartment(int id);
    }
}
