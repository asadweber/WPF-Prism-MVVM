using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_rolepermissionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
		
        Task<long> Update(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_rolepermissionEntity>> GetAll(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
		
        Task<IList<owin_rolepermissionEntity>> GetAllByPages(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_rolepermissionEntity> GetSingle(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_rolepermissionEntity>> GAPgListView(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
