

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_datacheckedFacadeObjects")]
    public partial interface Ireg_datacheckedFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_datacheckedEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_datacheckedEntity>> GetAll(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_datacheckedEntity>> GetAllByPages(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_datachecked(reg_datacheckedEntity Master, List<reg_datacheckedEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_datacheckedEntity> GetSingle(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_datacheckedEntity>> GAPgListView(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken); 
		#endregion
    
    }
}
