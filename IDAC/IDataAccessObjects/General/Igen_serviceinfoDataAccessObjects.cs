using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_serviceinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
		
        Task<long> Update(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_serviceinfoEntity> listAdded, IList<gen_serviceinfoEntity> listUpdated, IList<gen_serviceinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_serviceinfoEntity>> GetAll(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
		
        Task<IList<gen_serviceinfoEntity>> GetAllByPages(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_serviceinfoEntity> GetSingle(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_serviceinfoEntity>> GAPgListView(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
