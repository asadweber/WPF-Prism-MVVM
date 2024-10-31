

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_previousexperianceFacadeObjects")]
    public partial interface Ireg_previousexperianceFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_previousexperianceEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_previousexperianceEntity>> GetAll(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_previousexperianceEntity>> GetAllByPages(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_previousexperianceEntity> GetSingle(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_previousexperianceEntity>> GAPgListView(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
