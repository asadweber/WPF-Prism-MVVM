﻿

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_notificationfiledetFacadeObjects")]
    public partial interface Itran_notificationfiledetFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_notificationfiledetEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_notificationfiledetEntity>> GetAll(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_notificationfiledetEntity>> GetAllByPages(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_notificationfiledetEntity> GetSingle(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_notificationfiledetEntity>> GAPgListView(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken);
        #endregion

    }
}
