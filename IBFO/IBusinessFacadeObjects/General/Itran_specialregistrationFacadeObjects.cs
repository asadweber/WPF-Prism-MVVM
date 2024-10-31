

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_specialregistrationFacadeObjects")]
    public partial interface Itran_specialregistrationFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_specialregistrationEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_specialregistrationEntity>> GetAll(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_specialregistrationEntity>> GetAllByPages(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_specialregistrationEntity> GetSingle(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_specialregistrationEntity>> GAPgListView(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
