﻿using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_maritalstatusDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
		
        Task<long> Update(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_maritalstatusEntity> listAdded, IList<gen_maritalstatusEntity> listUpdated, IList<gen_maritalstatusEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_maritalstatusEntity>> GetAll(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
		
        Task<IList<gen_maritalstatusEntity>> GetAllByPages(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetreg_familly(gen_maritalstatusEntity masterEntity, IList<reg_famillyEntity> listAdded, IList<reg_famillyEntity> listUpdated, IList<reg_famillyEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_maritalstatusEntity> GetSingle(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_maritalstatusEntity>> GAPgListView(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
