

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_volunteermedclearanceFacadeObjects")]
    public partial interface Itran_volunteermedclearanceFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_volunteermedclearanceEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_volunteermedclearanceEntity>> GetAll(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_volunteermedclearanceEntity>> GetAllByPages(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_volunteermedclearanceEntity> GetSingle(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_volunteermedclearanceEntity>> GAPgListView(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
