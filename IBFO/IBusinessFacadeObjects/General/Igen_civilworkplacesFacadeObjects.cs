

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_civilworkplacesFacadeObjects")]
    public partial interface Igen_civilworkplacesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_civilworkplacesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_civilworkplacesEntity>> GetAll(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_civilworkplacesEntity>> GetAllByPages(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_civilworkplaces(gen_civilworkplacesEntity Master, List<gen_civilworkplacesEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_civilworkplacesEntity> GetSingle(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_civilworkplacesEntity>> GAPgListView(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken); 
		#endregion
    
    }
}
