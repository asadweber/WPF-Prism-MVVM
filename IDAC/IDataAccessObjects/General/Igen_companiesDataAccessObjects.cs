using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_companiesDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
		
        Task<long> Update(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_companiesEntity> listAdded, IList<gen_companiesEntity> listUpdated, IList<gen_companiesEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_companiesEntity>> GetAll(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
		
        Task<IList<gen_companiesEntity>> GetAllByPages(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_companiesEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_previousexperiance(gen_companiesEntity masterEntity, IList<reg_previousexperianceEntity> listAdded, IList<reg_previousexperianceEntity> listUpdated, IList<reg_previousexperianceEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_companiesEntity> GetSingle(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_companiesEntity>> GAPgListView(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_companiesEntity gen_companies, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
