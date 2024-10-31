using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_certificatesubjectsDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
		
        Task<long> Update(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_certificatesubjectsEntity> listAdded, IList<gen_certificatesubjectsEntity> listUpdated, IList<gen_certificatesubjectsEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_certificatesubjectsEntity>> GetAll(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
		
        Task<IList<gen_certificatesubjectsEntity>> GetAllByPages(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_certificatesubjectsEntity> GetSingle(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_certificatesubjectsEntity>> GAPgListView(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
