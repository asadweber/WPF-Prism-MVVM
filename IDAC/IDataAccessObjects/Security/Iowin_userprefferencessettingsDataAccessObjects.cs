using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_userprefferencessettingsDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
		
        Task<long> Update(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_userprefferencessettingsEntity> listAdded, IList<owin_userprefferencessettingsEntity> listUpdated, IList<owin_userprefferencessettingsEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_userprefferencessettingsEntity>> GetAll(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
		
        Task<IList<owin_userprefferencessettingsEntity>> GetAllByPages(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_userprefferencessettingsEntity> GetSingle(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_userprefferencessettingsEntity>> GAPgListView(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
