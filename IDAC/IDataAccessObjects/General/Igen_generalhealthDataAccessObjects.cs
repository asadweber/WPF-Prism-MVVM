using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_generalhealthDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
		
        Task<long> Update(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_generalhealthEntity> listAdded, IList<gen_generalhealthEntity> listUpdated, IList<gen_generalhealthEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_generalhealthEntity>> GetAll(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
		
        Task<IList<gen_generalhealthEntity>> GetAllByPages(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_generalhealthEntity> GetSingle(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_generalhealthEntity>> GAPgListView(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
