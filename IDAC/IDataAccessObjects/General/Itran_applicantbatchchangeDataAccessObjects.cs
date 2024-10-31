using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_applicantbatchchangeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
		
        Task<long> Update(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_applicantbatchchangeEntity> listAdded, IList<tran_applicantbatchchangeEntity> listUpdated, IList<tran_applicantbatchchangeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_applicantbatchchangeEntity>> GetAll(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
		
        Task<IList<tran_applicantbatchchangeEntity>> GetAllByPages(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_applicantbatchchangeEntity> GetSingle(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_applicantbatchchangeEntity>> GAPgListView(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
