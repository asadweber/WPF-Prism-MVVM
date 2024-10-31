using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_exportprofileDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
		
        Task<long> Update(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_exportprofileEntity> listAdded, IList<tran_exportprofileEntity> listUpdated, IList<tran_exportprofileEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_exportprofileEntity>> GetAll(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
		
        Task<IList<tran_exportprofileEntity>> GetAllByPages(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_exportprofileEntity> GetSingle(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_exportprofileEntity>> GAPgListView(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
