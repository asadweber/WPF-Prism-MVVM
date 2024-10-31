using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_batchcandidatecertificateDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
		
        Task<long> Update(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_batchcandidatecertificateEntity> listAdded, IList<gen_batchcandidatecertificateEntity> listUpdated, IList<gen_batchcandidatecertificateEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_batchcandidatecertificateEntity>> GetAll(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
		
        Task<IList<gen_batchcandidatecertificateEntity>> GetAllByPages(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_batchcandidatecertificateEntity> GetSingle(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_batchcandidatecertificateEntity>> GAPgListView(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
