using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_previousexperianceDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
		
        Task<long> Update(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_previousexperianceEntity> listAdded, IList<reg_previousexperianceEntity> listUpdated, IList<reg_previousexperianceEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_previousexperianceEntity>> GetAll(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
		
        Task<IList<reg_previousexperianceEntity>> GetAllByPages(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_previousexperianceEntity> GetSingle(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_previousexperianceEntity>> GAPgListView(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
