using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Iowin_forminfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
		
        Task<long> Update(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
        
        Task<long> Delete(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<owin_forminfoEntity> listAdded, IList<owin_forminfoEntity> listUpdated, IList<owin_forminfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<owin_forminfoEntity>> GetAll(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
		
        Task<IList<owin_forminfoEntity>> GetAllByPages(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_studentmenuskip(owin_forminfoEntity masterEntity, IList<cnf_studentmenuskipEntity> listAdded, IList<cnf_studentmenuskipEntity> listUpdated, IList<cnf_studentmenuskipEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetcnf_studentmenuskipdetail(owin_forminfoEntity masterEntity, IList<cnf_studentmenuskipdetailEntity> listAdded, IList<cnf_studentmenuskipdetailEntity> listUpdated, IList<cnf_studentmenuskipdetailEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_formaction(owin_forminfoEntity masterEntity, IList<owin_formactionEntity> listAdded, IList<owin_formactionEntity> listUpdated, IList<owin_formactionEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetowin_rolepermission(owin_forminfoEntity masterEntity, IList<owin_rolepermissionEntity> listAdded, IList<owin_rolepermissionEntity> listUpdated, IList<owin_rolepermissionEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<owin_forminfoEntity> GetSingle(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<owin_forminfoEntity>> GAPgListView(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
