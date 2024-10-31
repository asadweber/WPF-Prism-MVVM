using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_fileconfignameDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_fileconfignameEntity> listAdded, IList<cnf_fileconfignameEntity> listUpdated, IList<cnf_fileconfignameEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_fileconfignameEntity>> GetAll(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
		
        Task<IList<cnf_fileconfignameEntity>> GetAllByPages(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_fileconfignameEntity> GetSingle(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_fileconfignameEntity>> GAPgListView(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken);
        #endregion

    }
}
