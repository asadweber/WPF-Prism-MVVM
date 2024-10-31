using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_filerequiredDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_filerequiredEntity> listAdded, IList<cnf_filerequiredEntity> listUpdated, IList<cnf_filerequiredEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_filerequiredEntity>> GetAll(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
		
        Task<IList<cnf_filerequiredEntity>> GetAllByPages(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_batchcandidatereqfile(cnf_filerequiredEntity masterEntity, IList<gen_batchcandidatereqfileEntity> listAdded, IList<gen_batchcandidatereqfileEntity> listUpdated, IList<gen_batchcandidatereqfileEntity> listDeleted, CancellationToken cancellationToken);

        Task<long> SaveMasterDetreg_studentfilestorage(cnf_filerequiredEntity masterEntity, IList<reg_studentfilestorageEntity> listAdded, IList<reg_studentfilestorageEntity> listUpdated, IList<reg_studentfilestorageEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_filerequiredEntity> GetSingle(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_filerequiredEntity>> GAPgListView(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
