using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_residenttypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
		
        Task<long> Update(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_residenttypeEntity> listAdded, IList<gen_residenttypeEntity> listUpdated, IList<gen_residenttypeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_residenttypeEntity>> GetAll(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
		
        Task<IList<gen_residenttypeEntity>> GetAllByPages(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_basicinfo(gen_residenttypeEntity masterEntity, IList<reg_basicinfoEntity> listAdded, IList<reg_basicinfoEntity> listUpdated, IList<reg_basicinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_residenttypeEntity> GetSingle(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_residenttypeEntity>> GAPgListView(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
