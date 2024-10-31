using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_servicesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_servicesEntity gen_services, CancellationToken cancellationToken);
		
        Task<long> Update(gen_servicesEntity gen_services, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_servicesEntity gen_services, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_servicesEntity> listAdded, IList<gen_servicesEntity> listUpdated, IList<gen_servicesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_servicesEntity>> GetAll(gen_servicesEntity gen_services, CancellationToken cancellationToken);
		
        Task<IList<gen_servicesEntity>> GetAllByPages(gen_servicesEntity gen_services, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_servicesEntity> GetSingle(gen_servicesEntity gen_services, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_servicesEntity>> GAPgListView(gen_servicesEntity gen_services, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
