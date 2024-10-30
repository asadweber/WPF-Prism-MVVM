using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Core.Frame.Shared;

namespace Web.Core.Frame.Interfaces.Gateways.Repositories
{
    public interface IRepository<T> where T : owin_userEntity
    {
        Task<T> GetById(int id);
        Task<List<T>> ListAll();
        Task<T> GetSingleBySpec(ISpecification<T> spec);
        Task<List<T>> List(ISpecification<T> spec);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
