using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_applicantresultexpireDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
		
        Task<long> Update(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_applicantresultexpireEntity> listAdded, IList<tran_applicantresultexpireEntity> listUpdated, IList<tran_applicantresultexpireEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_applicantresultexpireEntity>> GetAll(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
		
        Task<IList<tran_applicantresultexpireEntity>> GetAllByPages(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_applicantresultexpireEntity> GetSingle(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_applicantresultexpireEntity>> GAPgListView(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
