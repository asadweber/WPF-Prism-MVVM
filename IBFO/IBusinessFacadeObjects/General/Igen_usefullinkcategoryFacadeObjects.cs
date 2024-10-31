

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_usefullinkcategoryFacadeObjects")]
    public partial interface Igen_usefullinkcategoryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_usefullinkcategoryEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_usefullinkcategoryEntity>> GetAll(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_usefullinkcategoryEntity>> GetAllByPages(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_usefullink(gen_usefullinkcategoryEntity Master, List<gen_usefullinkEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_usefullinkcategoryEntity> GetSingle(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_usefullinkcategoryEntity>> GAPgListView(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken); 
		#endregion
    
    }
}
