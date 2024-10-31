

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_skillproficiencyFacadeObjects")]
    public partial interface Igen_skillproficiencyFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_skillproficiencyEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_skillproficiencyEntity>> GetAll(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_skillproficiencyEntity>> GetAllByPages(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_language(gen_skillproficiencyEntity Master, List<reg_languageEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_skillproficiencyEntity> GetSingle(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_skillproficiencyEntity>> GAPgListView(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken); 
		#endregion
    
    }
}
