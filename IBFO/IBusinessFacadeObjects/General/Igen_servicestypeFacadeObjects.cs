

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_servicestypeFacadeObjects")]
    public partial interface Igen_servicestypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_servicestypeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_servicestypeEntity>> GetAll(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_servicestypeEntity>> GetAllByPages(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_services(gen_servicestypeEntity Master, List<gen_servicesEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_servicestypeEntity> GetSingle(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_servicestypeEntity>> GAPgListView(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
