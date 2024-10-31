using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_econtactlistDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
		
        Task<long> Update(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_econtactlistEntity> listAdded, IList<gen_econtactlistEntity> listUpdated, IList<gen_econtactlistEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_econtactlistEntity>> GetAll(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
		
        Task<IList<gen_econtactlistEntity>> GetAllByPages(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_econtactlistEntity> GetSingle(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_econtactlistEntity>> GAPgListView(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
