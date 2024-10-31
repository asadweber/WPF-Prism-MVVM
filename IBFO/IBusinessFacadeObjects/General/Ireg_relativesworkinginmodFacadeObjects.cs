

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_relativesworkinginmodFacadeObjects")]
    public partial interface Ireg_relativesworkinginmodFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_relativesworkinginmodEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_relativesworkinginmodEntity>> GetAll(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_relativesworkinginmodEntity>> GetAllByPages(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_relativesworkinginmodEntity> GetSingle(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_relativesworkinginmodEntity>> GAPgListView(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
