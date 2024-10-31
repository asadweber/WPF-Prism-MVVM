

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_emergencycontactinfoFacadeObjects")]
    public partial interface Ireg_emergencycontactinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_emergencycontactinfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_emergencycontactinfoEntity>> GetAll(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_emergencycontactinfoEntity>> GetAllByPages(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_relativesworkinginmod(reg_emergencycontactinfoEntity Master, List<reg_relativesworkinginmodEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_emergencycontactinfoEntity> GetSingle(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_emergencycontactinfoEntity>> GAPgListView(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken); 
		#endregion
    
    }
}
