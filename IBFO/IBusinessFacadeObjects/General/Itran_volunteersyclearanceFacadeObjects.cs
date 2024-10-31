

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_volunteersyclearanceFacadeObjects")]
    public partial interface Itran_volunteersyclearanceFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_volunteersyclearanceEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_volunteersyclearanceEntity>> GetAll(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_volunteersyclearanceEntity>> GetAllByPages(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_volunteersyclearanceEntity> GetSingle(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_volunteersyclearanceEntity>> GAPgListView(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
