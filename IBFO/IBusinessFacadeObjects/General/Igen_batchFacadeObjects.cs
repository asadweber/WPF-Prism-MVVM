

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_batchFacadeObjects")]
    public partial interface Igen_batchFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_batchEntity gen_batch, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_batchEntity gen_batch, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_batchEntity gen_batch, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_batchEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_batchEntity>> GetAll(gen_batchEntity gen_batch, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_batchEntity>> GetAllByPages(gen_batchEntity gen_batch, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatetypemap(gen_batchEntity Master, List<gen_batchcandidatetypemapEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_batchunitlist(gen_batchEntity Master, List<gen_batchunitlistEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_registrationinfo(gen_batchEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_applicantphases(gen_batchEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_exportprofile(gen_batchEntity Master, List<tran_exportprofileEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_specialregistration(gen_batchEntity Master, List<tran_specialregistrationEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_batchEntity> GetSingle(gen_batchEntity gen_batch, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_batchEntity>> GAPgListView(gen_batchEntity gen_batch, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_batchEntity gen_batch, CancellationToken cancellationToken); 
		#endregion
    
    }
}
