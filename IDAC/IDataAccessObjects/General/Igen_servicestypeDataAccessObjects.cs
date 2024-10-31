using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_servicestypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
		
        Task<long> Update(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_servicestypeEntity> listAdded, IList<gen_servicestypeEntity> listUpdated, IList<gen_servicestypeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_servicestypeEntity>> GetAll(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
		
        Task<IList<gen_servicestypeEntity>> GetAllByPages(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_services(gen_servicestypeEntity masterEntity, IList<gen_servicesEntity> listAdded, IList<gen_servicesEntity> listUpdated, IList<gen_servicesEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_servicestypeEntity> GetSingle(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_servicestypeEntity>> GAPgListView(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
