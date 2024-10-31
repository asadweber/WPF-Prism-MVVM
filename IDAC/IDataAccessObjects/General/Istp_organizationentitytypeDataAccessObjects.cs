using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Istp_organizationentitytypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
		
        Task<long> Update(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
        
        Task<long> Delete(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<stp_organizationentitytypeEntity> listAdded, IList<stp_organizationentitytypeEntity> listUpdated, IList<stp_organizationentitytypeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<stp_organizationentitytypeEntity>> GetAll(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
		
        Task<IList<stp_organizationentitytypeEntity>> GetAllByPages(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetstp_organizationentity(stp_organizationentitytypeEntity masterEntity, IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<stp_organizationentitytypeEntity> GetSingle(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<stp_organizationentitytypeEntity>> GAPgListView(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
