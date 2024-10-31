

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_genderFacadeObjects")]
    public partial interface Igen_genderFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_genderEntity gen_gender, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_genderEntity gen_gender, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_genderEntity gen_gender, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_genderEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_genderEntity>> GetAll(gen_genderEntity gen_gender, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_genderEntity>> GetAllByPages(gen_genderEntity gen_gender, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_genderEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_genderEntity> GetSingle(gen_genderEntity gen_gender, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_genderEntity>> GAPgListView(gen_genderEntity gen_gender, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_genderEntity gen_gender, CancellationToken cancellationToken); 
		#endregion
    
    }
}
