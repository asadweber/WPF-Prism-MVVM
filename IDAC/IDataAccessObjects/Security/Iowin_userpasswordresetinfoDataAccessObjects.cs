using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userpasswordresetinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userpasswordresetinfoEntity> listAdded, IList<owin_userpasswordresetinfoEntity> listUpdated, IList<owin_userpasswordresetinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userpasswordresetinfoEntity>> GetAll(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
		
        Task<IList<owin_userpasswordresetinfoEntity>> GetAllByPages(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userpasswordresetinfoEntity> GetSingle(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userpasswordresetinfoEntity>> GAPgListView(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
