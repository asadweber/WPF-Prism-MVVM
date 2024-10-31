using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Istp_organizationDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
		
        Task<long> Update(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
        
        Task<long> Delete(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<stp_organizationEntity> listAdded, IList<stp_organizationEntity> listUpdated, IList<stp_organizationEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<stp_organizationEntity>> GetAll(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
		
        Task<IList<stp_organizationEntity>> GetAllByPages(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetstp_organizationentity(stp_organizationEntity masterEntity, IList<stp_organizationentityEntity> listAdded, IList<stp_organizationentityEntity> listUpdated, IList<stp_organizationentityEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetstp_organizationentitytype(stp_organizationEntity masterEntity, IList<stp_organizationentitytypeEntity> listAdded, IList<stp_organizationentitytypeEntity> listUpdated, IList<stp_organizationentitytypeEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<stp_organizationEntity> GetSingle(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<stp_organizationEntity>> GAPgListView(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(stp_organizationEntity stp_organization, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
