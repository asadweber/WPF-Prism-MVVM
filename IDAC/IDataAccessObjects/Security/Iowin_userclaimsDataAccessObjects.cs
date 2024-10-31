using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userclaimsDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userclaimsEntity> listAdded, IList<owin_userclaimsEntity> listUpdated, IList<owin_userclaimsEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userclaimsEntity>> GetAll(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
		
        Task<IList<owin_userclaimsEntity>> GetAllByPages(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userclaimsEntity> GetSingle(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userclaimsEntity>> GAPgListView(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
