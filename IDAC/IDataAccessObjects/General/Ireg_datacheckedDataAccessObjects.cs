using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_datacheckedDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
		
        Task<long> Update(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_datacheckedEntity> listAdded, IList<reg_datacheckedEntity> listUpdated, IList<reg_datacheckedEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_datacheckedEntity>> GetAll(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
		
        Task<IList<reg_datacheckedEntity>> GetAllByPages(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_datachecked(reg_datacheckedEntity masterEntity, IList<reg_datacheckedEntity> listAdded, IList<reg_datacheckedEntity> listUpdated, IList<reg_datacheckedEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_datacheckedEntity> GetSingle(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_datacheckedEntity>> GAPgListView(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
