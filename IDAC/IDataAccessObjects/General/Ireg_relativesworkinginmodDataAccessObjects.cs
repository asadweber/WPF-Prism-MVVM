using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_relativesworkinginmodDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
		
        Task<long> Update(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_relativesworkinginmodEntity> listAdded, IList<reg_relativesworkinginmodEntity> listUpdated, IList<reg_relativesworkinginmodEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_relativesworkinginmodEntity>> GetAll(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
		
        Task<IList<reg_relativesworkinginmodEntity>> GetAllByPages(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_relativesworkinginmodEntity> GetSingle(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_relativesworkinginmodEntity>> GAPgListView(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
