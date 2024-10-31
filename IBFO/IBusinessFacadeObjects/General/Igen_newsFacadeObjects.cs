

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_newsFacadeObjects")]
    public partial interface Igen_newsFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_newsEntity gen_news, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_newsEntity gen_news, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_newsEntity gen_news, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_newsEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_newsEntity>> GetAll(gen_newsEntity gen_news, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_newsEntity>> GetAllByPages(gen_newsEntity gen_news, CancellationToken cancellationToken);

        #endregion GetAll

        #region Save Master/Details	
        [OperationContract]
        Task<long> SaveMasterDetgen_newsgallery(gen_newsEntity Master, List<gen_newsgalleryEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	

        #region Simple load Single Row
        [OperationContract]
        Task<gen_newsEntity> GetSingle(gen_newsEntity gen_news, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_newsEntity>> GAPgListView(gen_newsEntity gen_news, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        Task<long> UpdatePublished(gen_newsEntity gen_news, CancellationToken cancellationToken);
        [OperationContract]
        Task<long> UpdateReviewed(gen_newsEntity gen_news, CancellationToken cancellationToken);
        #endregion 
        
        
            
    }
}
