using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_servicestatusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
		
        Task<long> Update(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_servicestatusEntity> listAdded, IList<gen_servicestatusEntity> listUpdated, IList<gen_servicestatusEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_servicestatusEntity>> GetAll(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
		
        Task<IList<gen_servicestatusEntity>> GetAllByPages(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_servicestatusEntity> GetSingle(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_servicestatusEntity>> GAPgListView(gen_servicestatusEntity gen_servicestatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
