using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_educationmajorDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
		
        Task<long> Update(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_educationmajorEntity> listAdded, IList<gen_educationmajorEntity> listUpdated, IList<gen_educationmajorEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_educationmajorEntity>> GetAll(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
		
        Task<IList<gen_educationmajorEntity>> GetAllByPages(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_educationinfo(gen_educationmajorEntity masterEntity, IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_educationmajorEntity> GetSingle(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_educationmajorEntity>> GAPgListView(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
