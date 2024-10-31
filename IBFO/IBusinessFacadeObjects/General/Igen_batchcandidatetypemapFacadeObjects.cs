

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_batchcandidatetypemapFacadeObjects")]
    public partial interface Igen_batchcandidatetypemapFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_batchcandidatetypemapEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_batchcandidatetypemapEntity>> GetAll(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_batchcandidatetypemapEntity>> GetAllByPages(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatecertificate(gen_batchcandidatetypemapEntity Master, List<gen_batchcandidatecertificateEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatereqfile(gen_batchcandidatetypemapEntity Master, List<gen_batchcandidatereqfileEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandprofession(gen_batchcandidatetypemapEntity Master, List<gen_batchcandprofessionEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_batchcandidatetypemapEntity> GetSingle(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_batchcandidatetypemapEntity>> GAPgListView(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken); 
		#endregion
    
    }
}
