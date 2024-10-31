

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_languageFacadeObjects")]
    public partial interface Ireg_languageFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_languageEntity reg_language, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_languageEntity reg_language, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_languageEntity reg_language, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_languageEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_languageEntity>> GetAll(reg_languageEntity reg_language, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_languageEntity>> GetAllByPages(reg_languageEntity reg_language, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_languageEntity> GetSingle(reg_languageEntity reg_language, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_languageEntity>> GAPgListView(reg_languageEntity reg_language, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
