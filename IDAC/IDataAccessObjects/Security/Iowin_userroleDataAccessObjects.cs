using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userroleDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userroleEntity> listAdded, IList<owin_userroleEntity> listUpdated, IList<owin_userroleEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userroleEntity>> GetAll(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
		
        Task<IList<owin_userroleEntity>> GetAllByPages(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userroleEntity> GetSingle(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userroleEntity>> GAPgListView(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
