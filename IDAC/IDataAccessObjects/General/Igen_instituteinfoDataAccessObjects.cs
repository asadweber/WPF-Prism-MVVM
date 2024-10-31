using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_instituteinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
		
        Task<long> Update(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_instituteinfoEntity> listAdded, IList<gen_instituteinfoEntity> listUpdated, IList<gen_instituteinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_instituteinfoEntity>> GetAll(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
		
        Task<IList<gen_instituteinfoEntity>> GetAllByPages(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_educationinfo(gen_instituteinfoEntity masterEntity, IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_instituteinfoEntity> GetSingle(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_instituteinfoEntity>> GAPgListView(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
