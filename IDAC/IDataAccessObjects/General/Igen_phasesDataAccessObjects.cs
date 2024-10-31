using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_phasesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
		
        Task<long> Update(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_phasesEntity> listAdded, IList<gen_phasesEntity> listUpdated, IList<gen_phasesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_phasesEntity>> GetAll(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
		
        Task<IList<gen_phasesEntity>> GetAllByPages(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_notificationconfig(gen_phasesEntity masterEntity, IList<cnf_notificationconfigEntity> listAdded, IList<cnf_notificationconfigEntity> listUpdated, IList<cnf_notificationconfigEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_phases(gen_phasesEntity masterEntity, IList<gen_phasesEntity> listAdded, IList<gen_phasesEntity> listUpdated, IList<gen_phasesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_applicantphases(gen_phasesEntity masterEntity, IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_notificationbatch(gen_phasesEntity masterEntity, IList<tran_notificationbatchEntity> listAdded, IList<tran_notificationbatchEntity> listUpdated, IList<tran_notificationbatchEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_phasesEntity> GetSingle(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_phasesEntity>> GAPgListView(gen_phasesEntity gen_phases, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_phasesEntity gen_phases, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
