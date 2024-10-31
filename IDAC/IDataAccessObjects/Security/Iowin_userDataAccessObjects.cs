using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userEntity owin_user, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userEntity owin_user, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userEntity owin_user, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userEntity> listAdded, IList<owin_userEntity> listUpdated, IList<owin_userEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userEntity>> GetAll(owin_userEntity owin_user, CancellationToken cancellationToken);
		
        Task<IList<owin_userEntity>> GetAllByPages(owin_userEntity owin_user, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetowin_lastworkingpage(owin_userEntity masterEntity, IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_userclaims(owin_userEntity masterEntity, IList<owin_userclaimsEntity> listAdded, IList<owin_userclaimsEntity> listUpdated, IList<owin_userclaimsEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_userlogintrail(owin_userEntity masterEntity, IList<owin_userlogintrailEntity> listAdded, IList<owin_userlogintrailEntity> listUpdated, IList<owin_userlogintrailEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_userpasswordresetinfo(owin_userEntity masterEntity, IList<owin_userpasswordresetinfoEntity> listAdded, IList<owin_userpasswordresetinfoEntity> listUpdated, IList<owin_userpasswordresetinfoEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_userprefferencessettings(owin_userEntity masterEntity, IList<owin_userprefferencessettingsEntity> listAdded, IList<owin_userprefferencessettingsEntity> listUpdated, IList<owin_userprefferencessettingsEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_userrole(owin_userEntity masterEntity, IList<owin_userroleEntity> listAdded, IList<owin_userroleEntity> listUpdated, IList<owin_userroleEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userEntity> GetSingle(owin_userEntity owin_user, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userEntity>> GAPgListView(owin_userEntity owin_user, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        Task<long > UpdateReviewed(owin_userEntity owin_user, CancellationToken cancellationToken);
        #endregion        
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(owin_userEntity owin_user, CancellationToken cancellationToken);
    }
}
