

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_applicantphasesFacadeObjects")]
    public partial interface Itran_applicantphasesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_applicantphasesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_applicantphasesEntity>> GetAll(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_applicantphasesEntity>> GetAllByPages(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatchdet(tran_applicantphasesEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_applicantphasesEntity> GetSingle(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_applicantphasesEntity>> GAPgListView(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken); 
		#endregion
    
    }
}
