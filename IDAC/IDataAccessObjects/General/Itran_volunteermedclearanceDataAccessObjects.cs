using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_volunteermedclearanceDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
		
        Task<long> Update(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_volunteermedclearanceEntity> listAdded, IList<tran_volunteermedclearanceEntity> listUpdated, IList<tran_volunteermedclearanceEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_volunteermedclearanceEntity>> GetAll(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
		
        Task<IList<tran_volunteermedclearanceEntity>> GetAllByPages(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_volunteermedclearanceEntity> GetSingle(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_volunteermedclearanceEntity>> GAPgListView(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
