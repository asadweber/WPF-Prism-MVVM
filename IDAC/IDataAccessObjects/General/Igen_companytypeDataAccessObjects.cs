using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_companytypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
		
        Task<long> Update(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_companytypeEntity> listAdded, IList<gen_companytypeEntity> listUpdated, IList<gen_companytypeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_companytypeEntity>> GetAll(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
		
        Task<IList<gen_companytypeEntity>> GetAllByPages(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_companies(gen_companytypeEntity masterEntity, IList<gen_companiesEntity> listAdded, IList<gen_companiesEntity> listUpdated, IList<gen_companiesEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_previousexperiance(gen_companytypeEntity masterEntity, IList<reg_previousexperianceEntity> listAdded, IList<reg_previousexperianceEntity> listUpdated, IList<reg_previousexperianceEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_companytypeEntity> GetSingle(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_companytypeEntity>> GAPgListView(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
