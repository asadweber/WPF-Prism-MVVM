using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_certificatelevelDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
		
        Task<long> Update(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_certificatelevelEntity> listAdded, IList<gen_certificatelevelEntity> listUpdated, IList<gen_certificatelevelEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_certificatelevelEntity>> GetAll(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
		
        Task<IList<gen_certificatelevelEntity>> GetAllByPages(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandidatecertificate(gen_certificatelevelEntity masterEntity, IList<gen_batchcandidatecertificateEntity> listAdded, IList<gen_batchcandidatecertificateEntity> listUpdated, IList<gen_batchcandidatecertificateEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetgen_certificate(gen_certificatelevelEntity masterEntity, IList<gen_certificateEntity> listAdded, IList<gen_certificateEntity> listUpdated, IList<gen_certificateEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_certificatelevelEntity> GetSingle(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_certificatelevelEntity>> GAPgListView(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
