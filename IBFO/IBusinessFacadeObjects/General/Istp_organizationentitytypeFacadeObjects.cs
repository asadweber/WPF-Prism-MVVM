

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Istp_organizationentitytypeFacadeObjects")]
    public partial interface Istp_organizationentitytypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<stp_organizationentitytypeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<stp_organizationentitytypeEntity>> GetAll(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<stp_organizationentitytypeEntity>> GetAllByPages(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetstp_organizationentity(stp_organizationentitytypeEntity Master, List<stp_organizationentityEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<stp_organizationentitytypeEntity> GetSingle(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<stp_organizationentitytypeEntity>> GAPgListView(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
