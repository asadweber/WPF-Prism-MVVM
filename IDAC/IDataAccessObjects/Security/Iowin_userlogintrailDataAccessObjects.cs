using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userlogintrailDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userlogintrailEntity> listAdded, IList<owin_userlogintrailEntity> listUpdated, IList<owin_userlogintrailEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userlogintrailEntity>> GetAll(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
		
        Task<IList<owin_userlogintrailEntity>> GetAllByPages(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userlogintrailEntity> GetSingle(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userlogintrailEntity>> GAPgListView(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
