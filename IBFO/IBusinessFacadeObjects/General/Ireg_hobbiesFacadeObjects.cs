

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_hobbiesFacadeObjects")]
    public partial interface Ireg_hobbiesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_hobbiesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_hobbiesEntity>> GetAll(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_hobbiesEntity>> GetAllByPages(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_hobbiesEntity> GetSingle(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_hobbiesEntity>> GAPgListView(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
