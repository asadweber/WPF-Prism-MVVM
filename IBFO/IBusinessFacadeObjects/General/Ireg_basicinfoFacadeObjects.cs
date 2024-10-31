

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_basicinfoFacadeObjects")]
    public partial interface Ireg_basicinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_basicinfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_basicinfoEntity>> GetAll(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_basicinfoEntity>> GetAllByPages(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_smsactivationcode(reg_basicinfoEntity Master, List<cnf_smsactivationcodeEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetcnf_studentmenuskipdetail(reg_basicinfoEntity Master, List<cnf_studentmenuskipdetailEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_educationinfo(reg_basicinfoEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_familly(reg_basicinfoEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_hobbies(reg_basicinfoEntity Master, List<reg_hobbiesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_language(reg_basicinfoEntity Master, List<reg_languageEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_nonkuwaitystatus(reg_basicinfoEntity Master, List<reg_nonkuwaitystatusEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_previousexperiance(reg_basicinfoEntity Master, List<reg_previousexperianceEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_punishment(reg_basicinfoEntity Master, List<reg_punishmentEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_registrationinfo(reg_basicinfoEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_relativesworkinginmod(reg_basicinfoEntity Master, List<reg_relativesworkinginmodEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_studentfilestorage(reg_basicinfoEntity Master, List<reg_studentfilestorageEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_applicantphases(reg_basicinfoEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_exportprofile(reg_basicinfoEntity Master, List<tran_exportprofileEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatchdet(reg_basicinfoEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_rollbackinfo(reg_basicinfoEntity Master, List<tran_rollbackinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_basicinfoEntity> GetSingle(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_basicinfoEntity>> GAPgListView(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken); 
		#endregion
    
    }
}
