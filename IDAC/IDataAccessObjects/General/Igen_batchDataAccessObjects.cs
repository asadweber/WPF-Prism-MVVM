using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_batchDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_batchEntity gen_batch, CancellationToken cancellationToken);
		
        Task<long> Update(gen_batchEntity gen_batch, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_batchEntity gen_batch, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_batchEntity> listAdded, IList<gen_batchEntity> listUpdated, IList<gen_batchEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_batchEntity>> GetAll(gen_batchEntity gen_batch, CancellationToken cancellationToken);
		
        Task<IList<gen_batchEntity>> GetAllByPages(gen_batchEntity gen_batch, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandidatetypemap(gen_batchEntity masterEntity, IList<gen_batchcandidatetypemapEntity> listAdded, IList<gen_batchcandidatetypemapEntity> listUpdated, IList<gen_batchcandidatetypemapEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_batchunitlist(gen_batchEntity masterEntity, IList<gen_batchunitlistEntity> listAdded, IList<gen_batchunitlistEntity> listUpdated, IList<gen_batchunitlistEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_registrationinfo(gen_batchEntity masterEntity, IList<reg_registrationinfoEntity> listAdded, IList<reg_registrationinfoEntity> listUpdated, IList<reg_registrationinfoEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_applicantphases(gen_batchEntity masterEntity, IList<tran_applicantphasesEntity> listAdded, IList<tran_applicantphasesEntity> listUpdated, IList<tran_applicantphasesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_exportprofile(gen_batchEntity masterEntity, IList<tran_exportprofileEntity> listAdded, IList<tran_exportprofileEntity> listUpdated, IList<tran_exportprofileEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDettran_specialregistration(gen_batchEntity masterEntity, IList<tran_specialregistrationEntity> listAdded, IList<tran_specialregistrationEntity> listUpdated, IList<tran_specialregistrationEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_batchEntity> GetSingle(gen_batchEntity gen_batch, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_batchEntity>> GAPgListView(gen_batchEntity gen_batch, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_batchEntity gen_batch, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
