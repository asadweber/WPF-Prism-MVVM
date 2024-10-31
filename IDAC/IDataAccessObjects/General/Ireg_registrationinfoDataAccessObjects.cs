using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_registrationinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
		
        Task<long> Update(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_registrationinfoEntity> listAdded, IList<reg_registrationinfoEntity> listUpdated, IList<reg_registrationinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_registrationinfoEntity>> GetAll(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
		
        Task<IList<reg_registrationinfoEntity>> GetAllByPages(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_studentfilestorage(reg_registrationinfoEntity masterEntity, IList<reg_studentfilestorageEntity> listAdded, IList<reg_studentfilestorageEntity> listUpdated, IList<reg_studentfilestorageEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_applicantphases(reg_registrationinfoEntity masterEntity, IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_exportprofile(reg_registrationinfoEntity masterEntity, IList<tran_exportprofileEntity> listAdded, IList<tran_exportprofileEntity> listUpdated, IList<tran_exportprofileEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_notificationbatchdet(reg_registrationinfoEntity masterEntity, IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_rollbackinfo(reg_registrationinfoEntity masterEntity, IList<tran_rollbackinfoEntity> listAdded, IList<tran_rollbackinfoEntity> listUpdated, IList<tran_rollbackinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_registrationinfoEntity> GetSingle(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_registrationinfoEntity>> GAPgListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
