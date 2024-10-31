

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_notificationfileFacadeObjects")]
    public partial interface Itran_notificationfileFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_notificationfileEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_notificationfileEntity>> GetAll(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_notificationfileEntity>> GetAllByPages(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_notificationfileEntity> GetSingle(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_notificationfileEntity>> GAPgListView(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken);
        #endregion

    }
}
