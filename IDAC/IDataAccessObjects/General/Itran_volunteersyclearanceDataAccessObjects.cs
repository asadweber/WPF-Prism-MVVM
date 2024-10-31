using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_volunteersyclearanceDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
		
        Task<long> Update(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_volunteersyclearanceEntity> listAdded, IList<tran_volunteersyclearanceEntity> listUpdated, IList<tran_volunteersyclearanceEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_volunteersyclearanceEntity>> GetAll(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
		
        Task<IList<tran_volunteersyclearanceEntity>> GetAllByPages(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_volunteersyclearanceEntity> GetSingle(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_volunteersyclearanceEntity>> GAPgListView(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
