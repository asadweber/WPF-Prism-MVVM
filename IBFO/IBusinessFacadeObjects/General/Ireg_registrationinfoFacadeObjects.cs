

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_registrationinfoFacadeObjects")]
    public partial interface Ireg_registrationinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_registrationinfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetAll(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_registrationinfoEntity>> GetAllByPages(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_studentfilestorage(reg_registrationinfoEntity Master, List<reg_studentfilestorageEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_applicantphases(reg_registrationinfoEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_exportprofile(reg_registrationinfoEntity Master, List<tran_exportprofileEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatchdet(reg_registrationinfoEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_rollbackinfo(reg_registrationinfoEntity Master, List<tran_rollbackinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_registrationinfoEntity> GetSingle(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_registrationinfoEntity>> GAPgListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken); 
		#endregion
    
    }
}
