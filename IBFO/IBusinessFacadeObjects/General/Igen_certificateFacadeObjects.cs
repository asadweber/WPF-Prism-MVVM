

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_certificateFacadeObjects")]
    public partial interface Igen_certificateFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_certificateEntity gen_certificate, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_certificateEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_certificateEntity>> GetAll(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_certificateEntity>> GetAllByPages(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatecertificate(gen_certificateEntity Master, List<gen_batchcandidatecertificateEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_certificatesubjects(gen_certificateEntity Master, List<gen_certificatesubjectsEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_certificateEntity> GetSingle(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_certificateEntity>> GAPgListView(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken); 
		#endregion
    
    }
}
