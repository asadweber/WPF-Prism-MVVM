

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_volunteerunitclearanceFacadeObjects")]
    public partial interface Itran_volunteerunitclearanceFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_volunteerunitclearanceEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_volunteerunitclearanceEntity>> GetAll(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_volunteerunitclearanceEntity>> GetAllByPages(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_volunteerunitclearanceEntity> GetSingle(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_volunteerunitclearanceEntity>> GAPgListView(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
