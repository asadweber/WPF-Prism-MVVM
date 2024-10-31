

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_certificatelevelFacadeObjects")]
    public partial interface Igen_certificatelevelFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_certificatelevelEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_certificatelevelEntity>> GetAll(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_certificatelevelEntity>> GetAllByPages(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatecertificate(gen_certificatelevelEntity Master, List<gen_batchcandidatecertificateEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_certificate(gen_certificatelevelEntity Master, List<gen_certificateEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_certificatelevelEntity> GetSingle(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_certificatelevelEntity>> GAPgListView(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken); 
		#endregion
    
    }
}
