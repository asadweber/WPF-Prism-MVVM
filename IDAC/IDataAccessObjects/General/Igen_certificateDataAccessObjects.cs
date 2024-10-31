using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_certificateDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
		
        Task<long> Update(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_certificateEntity> listAdded, IList<gen_certificateEntity> listUpdated, IList<gen_certificateEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_certificateEntity>> GetAll(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
		
        Task<IList<gen_certificateEntity>> GetAllByPages(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandidatecertificate(gen_certificateEntity masterEntity, IList<gen_batchcandidatecertificateEntity> listAdded, IList<gen_batchcandidatecertificateEntity> listUpdated, IList<gen_batchcandidatecertificateEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_certificatesubjects(gen_certificateEntity masterEntity, IList<gen_certificatesubjectsEntity> listAdded, IList<gen_certificatesubjectsEntity> listUpdated, IList<gen_certificatesubjectsEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_certificateEntity> GetSingle(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_certificateEntity>> GAPgListView(gen_certificateEntity gen_certificate, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
