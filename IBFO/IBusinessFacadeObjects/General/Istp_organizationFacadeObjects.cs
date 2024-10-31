

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Istp_organizationFacadeObjects")]
    public partial interface Istp_organizationFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(stp_organizationEntity stp_organization, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<stp_organizationEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<stp_organizationEntity>> GetAll(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<stp_organizationEntity>> GetAllByPages(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetstp_organizationentity(stp_organizationEntity Master, List<stp_organizationentityEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetstp_organizationentitytype(stp_organizationEntity Master, List<stp_organizationentitytypeEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<stp_organizationEntity> GetSingle(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<stp_organizationEntity>> GAPgListView(stp_organizationEntity stp_organization, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(stp_organizationEntity stp_organization, CancellationToken cancellationToken); 
		#endregion
    
    }
}
