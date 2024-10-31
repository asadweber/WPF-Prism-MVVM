

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_residenttypeFacadeObjects")]
    public partial interface Igen_residenttypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_residenttypeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_residenttypeEntity>> GetAll(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_residenttypeEntity>> GetAllByPages(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_basicinfo(gen_residenttypeEntity Master, List<reg_basicinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_residenttypeEntity> GetSingle(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_residenttypeEntity>> GAPgListView(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
