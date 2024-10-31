using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_professiongroupDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
		
        Task<long> Update(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_professiongroupEntity> listAdded, IList<gen_professiongroupEntity> listUpdated, IList<gen_professiongroupEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_professiongroupEntity>> GetAll(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
		
        Task<IList<gen_professiongroupEntity>> GetAllByPages(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_profession(gen_professiongroupEntity masterEntity, IList<gen_professionEntity> listAdded, IList<gen_professionEntity> listUpdated, IList<gen_professionEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_professiongroupEntity> GetSingle(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_professiongroupEntity>> GAPgListView(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
