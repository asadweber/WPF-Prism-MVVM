

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_batchcandidatecertificateFacadeObjects")]
    public partial interface Igen_batchcandidatecertificateFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_batchcandidatecertificateEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_batchcandidatecertificateEntity>> GetAll(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_batchcandidatecertificateEntity>> GetAllByPages(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_batchcandidatecertificateEntity> GetSingle(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_batchcandidatecertificateEntity>> GAPgListView(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
