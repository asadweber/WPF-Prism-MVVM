

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_newscategoryFacadeObjects")]
    public partial interface Igen_newscategoryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_newscategoryEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_newscategoryEntity>> GetAll(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_newscategoryEntity>> GetAllByPages(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_news(gen_newscategoryEntity Master, List<gen_newsEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_newscategory(gen_newscategoryEntity Master, List<gen_newscategoryEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_newscategoryEntity> GetSingle(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_newscategoryEntity>> GAPgListView(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken); 
		#endregion
    
    }
}
