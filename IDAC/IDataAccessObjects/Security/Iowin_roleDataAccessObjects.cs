using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_roleDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_roleEntity owin_role, CancellationToken cancellationToken);
		
        Task<long> Update(owin_roleEntity owin_role, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_roleEntity owin_role, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_roleEntity> listAdded, IList<owin_roleEntity> listUpdated, IList<owin_roleEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_roleEntity>> GetAll(owin_roleEntity owin_role, CancellationToken cancellationToken);
		
        Task<IList<owin_roleEntity>> GetAllByPages(owin_roleEntity owin_role, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_roleEntity> GetSingle(owin_roleEntity owin_role, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_roleEntity>> GAPgListView(owin_roleEntity owin_role, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(owin_roleEntity owin_role, CancellationToken cancellationToken);
        #endregion
    }
}
