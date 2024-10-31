

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Istp_organizationentityFacadeObjects")]
    public partial interface Istp_organizationentityFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<stp_organizationentityEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<stp_organizationentityEntity>> GetAll(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<stp_organizationentityEntity>> GetAllByPages(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_relativesworkinginmod(stp_organizationentityEntity Master, List<reg_relativesworkinginmodEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetstp_organizationentity(stp_organizationentityEntity Master, List<stp_organizationentityEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<stp_organizationentityEntity> GetSingle(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<stp_organizationentityEntity>> GAPgListView(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken); 
		#endregion
    
    }
}
