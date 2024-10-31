

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_maritalstatusFacadeObjects")]
    public partial interface Igen_maritalstatusFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_maritalstatusEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_maritalstatusEntity>> GetAll(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_maritalstatusEntity>> GetAllByPages(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_maritalstatusEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_maritalstatusEntity> GetSingle(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_maritalstatusEntity>> GAPgListView(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken); 
		#endregion
    
    }
}
