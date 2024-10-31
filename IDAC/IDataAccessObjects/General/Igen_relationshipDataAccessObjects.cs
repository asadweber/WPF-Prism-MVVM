using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_relationshipDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
		
        Task<long> Update(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_relationshipEntity> listAdded, IList<gen_relationshipEntity> listUpdated, IList<gen_relationshipEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_relationshipEntity>> GetAll(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
		
        Task<IList<gen_relationshipEntity>> GetAllByPages(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_relationshipEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_relationshipEntity> GetSingle(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_relationshipEntity>> GAPgListView(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
