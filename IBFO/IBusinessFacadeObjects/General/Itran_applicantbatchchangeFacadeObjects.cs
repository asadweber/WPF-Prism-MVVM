

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_applicantbatchchangeFacadeObjects")]
    public partial interface Itran_applicantbatchchangeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_applicantbatchchangeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_applicantbatchchangeEntity>> GetAll(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_applicantbatchchangeEntity>> GetAllByPages(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_applicantbatchchangeEntity> GetSingle(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_applicantbatchchangeEntity>> GAPgListView(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
