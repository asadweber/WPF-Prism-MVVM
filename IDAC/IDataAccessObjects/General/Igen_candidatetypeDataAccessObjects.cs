
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_candidatetypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
		
        Task<long> Update(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_candidatetypeEntity> listAdded, IList<gen_candidatetypeEntity> listUpdated, IList<gen_candidatetypeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_candidatetypeEntity>> GetAll(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
		
        Task<IList<gen_candidatetypeEntity>> GetAllByPages(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandidatetypemap(gen_candidatetypeEntity masterEntity, IList<gen_batchcandidatetypemapEntity> listAdded, IList<gen_batchcandidatetypemapEntity> listUpdated, IList<gen_batchcandidatetypemapEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_registrationinfo(gen_candidatetypeEntity masterEntity, IList<reg_registrationinfoEntity> listAdded, IList<reg_registrationinfoEntity> listUpdated, IList<reg_registrationinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_candidatetypeEntity> GetSingle(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_candidatetypeEntity>> GAPgListView(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
