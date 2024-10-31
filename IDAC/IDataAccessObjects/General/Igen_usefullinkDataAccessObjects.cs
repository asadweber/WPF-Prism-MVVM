using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_usefullinkDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
		
        Task<long> Update(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_usefullinkEntity> listAdded, IList<gen_usefullinkEntity> listUpdated, IList<gen_usefullinkEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_usefullinkEntity>> GetAll(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
		
        Task<IList<gen_usefullinkEntity>> GetAllByPages(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_usefullinkEntity> GetSingle(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_usefullinkEntity>> GAPgListView(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
