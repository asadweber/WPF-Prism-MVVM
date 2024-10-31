

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_newsgalleryFacadeObjects")]
    public partial interface Igen_newsgalleryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
        
		[OperationContract]
        Task<long> Update(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<long> Delete(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_newsgalleryEntity> list, CancellationToken cancellationToken);                  
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_newsgalleryEntity>> GetAll(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_newsgalleryEntity>> GetAllByPages(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_newsgalleryEntity> GetSingle(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
        Task<IList<gen_newsgalleryEntity>> GAPgListView(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
