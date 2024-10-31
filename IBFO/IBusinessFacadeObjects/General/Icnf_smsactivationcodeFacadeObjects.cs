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
    [ServiceContract(Name = "Icnf_smsactivationcodeFacadeObjects")]
    public partial interface Icnf_smsactivationcodeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_smsactivationcodeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_smsactivationcodeEntity>> GetAll(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_smsactivationcodeEntity>> GetAllByPages(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_smsactivationtransection(cnf_smsactivationcodeEntity Master, List<cnf_smsactivationtransectionEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_smsactivationcodeEntity> GetSingle(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_smsactivationcodeEntity>> GAPgListView(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken); 
		#endregion
    
    }
}
