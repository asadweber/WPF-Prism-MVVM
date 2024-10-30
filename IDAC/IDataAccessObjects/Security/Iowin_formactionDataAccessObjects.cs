using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.Security
{
	public partial interface Iowin_formactionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
		
        Task<long> Update(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_formactionEntity>> GetAll(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
		
        Task<IList<owin_formactionEntity>> GetAllByPages(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetowin_formaction(owin_formactionEntity masterEntity, IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_lastworkingpage(owin_formactionEntity masterEntity, IList<owin_lastworkingpageEntity> listAdded, IList<owin_lastworkingpageEntity> listUpdated, IList<owin_lastworkingpageEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_rolepermission(owin_formactionEntity masterEntity, IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_formactionEntity> GetSingle(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_formactionEntity>> GAPgListView(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
    }
}
