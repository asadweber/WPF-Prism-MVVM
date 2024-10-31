using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_generallookDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
		
        Task<long> Update(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_generallookEntity> listAdded, IList<gen_generallookEntity> listUpdated, IList<gen_generallookEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_generallookEntity>> GetAll(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
		
        Task<IList<gen_generallookEntity>> GetAllByPages(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_generallookEntity> GetSingle(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_generallookEntity>> GAPgListView(gen_generallookEntity gen_generallook, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
