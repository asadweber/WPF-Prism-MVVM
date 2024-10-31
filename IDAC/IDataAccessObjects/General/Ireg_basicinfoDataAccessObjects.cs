using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_basicinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
		
        Task<long> Update(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_basicinfoEntity> listAdded, IList<reg_basicinfoEntity> listUpdated, IList<reg_basicinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_basicinfoEntity>> GetAll(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
		
        Task<IList<reg_basicinfoEntity>> GetAllByPages(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_smsactivationcode(reg_basicinfoEntity masterEntity, IList<cnf_smsactivationcodeEntity> listAdded, IList<cnf_smsactivationcodeEntity> listUpdated, IList<cnf_smsactivationcodeEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetcnf_studentmenuskipdetail(reg_basicinfoEntity masterEntity, IList<cnf_studentmenuskipdetailEntity> listAdded, IList<cnf_studentmenuskipdetailEntity> listUpdated, IList<cnf_studentmenuskipdetailEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_educationinfo(reg_basicinfoEntity masterEntity, IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_familly(reg_basicinfoEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_hobbies(reg_basicinfoEntity masterEntity, IList<reg_hobbiesEntity> listAdded, IList<reg_hobbiesEntity> listUpdated, IList<reg_hobbiesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_language(reg_basicinfoEntity masterEntity, IList<reg_languageEntity> listAdded, IList<reg_languageEntity> listUpdated, IList<reg_languageEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_nonkuwaitystatus(reg_basicinfoEntity masterEntity, IList<reg_nonkuwaitystatusEntity> listAdded, IList<reg_nonkuwaitystatusEntity> listUpdated, IList<reg_nonkuwaitystatusEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_previousexperiance(reg_basicinfoEntity masterEntity, IList<reg_previousexperianceEntity> listAdded, IList<reg_previousexperianceEntity> listUpdated, IList<reg_previousexperianceEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_punishment(reg_basicinfoEntity masterEntity, IList<reg_punishmentEntity> listAdded, IList<reg_punishmentEntity> listUpdated, IList<reg_punishmentEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_registrationinfo(reg_basicinfoEntity masterEntity, IList<reg_registrationinfoEntity> listAdded, IList<reg_registrationinfoEntity> listUpdated, IList<reg_registrationinfoEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_relativesworkinginmod(reg_basicinfoEntity masterEntity, IList<reg_relativesworkinginmodEntity> listAdded, IList<reg_relativesworkinginmodEntity> listUpdated, IList<reg_relativesworkinginmodEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_studentfilestorage(reg_basicinfoEntity masterEntity, IList<reg_studentfilestorageEntity> listAdded, IList<reg_studentfilestorageEntity> listUpdated, IList<reg_studentfilestorageEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_applicantphases(reg_basicinfoEntity masterEntity, IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_exportprofile(reg_basicinfoEntity masterEntity, IList<tran_exportprofileEntity> listAdded, IList<tran_exportprofileEntity> listUpdated, IList<tran_exportprofileEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_notificationbatchdet(reg_basicinfoEntity masterEntity, IList<tran_notificationbatchdetEntity> listAdded, IList<tran_notificationbatchdetEntity> listUpdated, IList<tran_notificationbatchdetEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_rollbackinfo(reg_basicinfoEntity masterEntity, IList<tran_rollbackinfoEntity> listAdded, IList<tran_rollbackinfoEntity> listUpdated, IList<tran_rollbackinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_basicinfoEntity> GetSingle(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_basicinfoEntity>> GAPgListView(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
