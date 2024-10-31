

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_applicanttablesFacadeObjects")]
    public partial interface Igen_applicanttablesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_applicanttablesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_applicanttablesEntity>> GetAll(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_applicanttablesEntity>> GetAllByPages(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_datachecked(gen_applicanttablesEntity Master, List<reg_datacheckedEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_applicanttablesEntity> GetSingle(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_applicanttablesEntity>> GAPgListView(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken); 
		#endregion
    
    }
}
