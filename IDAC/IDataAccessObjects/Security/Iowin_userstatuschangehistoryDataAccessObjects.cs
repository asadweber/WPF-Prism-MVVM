using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userstatuschangehistoryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userstatuschangehistoryEntity> listAdded, IList<owin_userstatuschangehistoryEntity> listUpdated, IList<owin_userstatuschangehistoryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userstatuschangehistoryEntity>> GetAll(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
		
        Task<IList<owin_userstatuschangehistoryEntity>> GetAllByPages(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userstatuschangehistoryEntity> GetSingle(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userstatuschangehistoryEntity>> GAPgListView(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
