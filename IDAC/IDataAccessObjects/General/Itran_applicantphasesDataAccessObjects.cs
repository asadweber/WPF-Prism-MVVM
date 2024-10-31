using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_applicantphasesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
		
        Task<long> Update(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_applicantphasesEntity>> GetAll(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
		
        Task<IList<tran_applicantphasesEntity>> GetAllByPages(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDettran_notificationbatchdet(tran_applicantphasesEntity masterEntity, IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_applicantphasesEntity> GetSingle(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_applicantphasesEntity>> GAPgListView(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
