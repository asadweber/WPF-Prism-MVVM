

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_phasesFacadeObjects")]
    public partial interface Igen_phasesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_phasesEntity gen_phases, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_phasesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_phasesEntity>> GetAll(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_phasesEntity>> GetAllByPages(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetcnf_notificationconfig(gen_phasesEntity Master, List<cnf_notificationconfigEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_phases(gen_phasesEntity Master, List<gen_phasesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_applicantphases(gen_phasesEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDettran_notificationbatch(gen_phasesEntity Master, List<tran_notificationbatchEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_phasesEntity> GetSingle(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_phasesEntity>> GAPgListView(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_phasesEntity gen_phases, CancellationToken cancellationToken); 
		#endregion
    
    }
}
