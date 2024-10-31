

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_languagesFacadeObjects")]
    public partial interface Igen_languagesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_languagesEntity gen_languages, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_languagesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_languagesEntity>> GetAll(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_languagesEntity>> GetAllByPages(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_language(gen_languagesEntity Master, List<reg_languageEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_languagesEntity> GetSingle(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_languagesEntity>> GAPgListView(gen_languagesEntity gen_languages, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_languagesEntity gen_languages, CancellationToken cancellationToken); 
		#endregion
    
    }
}
