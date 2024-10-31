

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_countrycityFacadeObjects")]
    public partial interface Igen_countrycityFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_countrycityEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_countrycityEntity>> GetAll(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_countrycityEntity>> GetAllByPages(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_civilworkplaces(gen_countrycityEntity Master, List<gen_civilworkplacesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_countrycity(gen_countrycityEntity Master, List<gen_countrycityEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_countrycityEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_countrycityEntity> GetSingle(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_countrycityEntity>> GAPgListView(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken); 
		#endregion
    
    }
}
