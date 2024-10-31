using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_specialregistrationDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
		
        Task<long> Update(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_specialregistrationEntity> listAdded, IList<tran_specialregistrationEntity> listUpdated, IList<tran_specialregistrationEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_specialregistrationEntity>> GetAll(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
		
        Task<IList<tran_specialregistrationEntity>> GetAllByPages(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_specialregistrationEntity> GetSingle(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_specialregistrationEntity>> GAPgListView(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
