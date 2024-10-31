using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userrolesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userrolesEntity> listAdded, IList<owin_userrolesEntity> listUpdated, IList<owin_userrolesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userrolesEntity>> GetAll(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
		
        Task<IList<owin_userrolesEntity>> GetAllByPages(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userrolesEntity> GetSingle(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userrolesEntity>> GAPgListView(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
