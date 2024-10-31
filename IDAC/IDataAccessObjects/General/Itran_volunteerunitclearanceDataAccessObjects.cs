using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_volunteerunitclearanceDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
		
        Task<long> Update(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_volunteerunitclearanceEntity> listAdded, IList<tran_volunteerunitclearanceEntity> listUpdated, IList<tran_volunteerunitclearanceEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_volunteerunitclearanceEntity>> GetAll(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
		
        Task<IList<tran_volunteerunitclearanceEntity>> GetAllByPages(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_volunteerunitclearanceEntity> GetSingle(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_volunteerunitclearanceEntity>> GAPgListView(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
