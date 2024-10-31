

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_certificatetypeFacadeObjects")]
    public partial interface Igen_certificatetypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_certificatetypeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_certificatetypeEntity>> GetAll(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_certificatetypeEntity>> GetAllByPages(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_certificate(gen_certificatetypeEntity Master, List<gen_certificateEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_certificatetypeEntity> GetSingle(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_certificatetypeEntity>> GAPgListView(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
