

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_countryclassFacadeObjects")]
    public partial interface Igen_countryclassFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_countryclassEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_countryclassEntity>> GetAll(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_countryclassEntity>> GetAllByPages(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_countryclassEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_countryclassEntity> GetSingle(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_countryclassEntity>> GAPgListView(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken); 
		#endregion
    
    }
}
