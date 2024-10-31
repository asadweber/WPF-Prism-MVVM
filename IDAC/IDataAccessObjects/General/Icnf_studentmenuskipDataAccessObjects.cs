using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_studentmenuskipDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_studentmenuskipEntity> listAdded, IList<cnf_studentmenuskipEntity> listUpdated, IList<cnf_studentmenuskipEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_studentmenuskipEntity>> GetAll(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
		
        Task<IList<cnf_studentmenuskipEntity>> GetAllByPages(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_studentmenuskipdetail(cnf_studentmenuskipEntity masterEntity, IList<cnf_studentmenuskipdetailEntity> listAdded, IList<cnf_studentmenuskipdetailEntity> listUpdated, IList<cnf_studentmenuskipdetailEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_studentmenuskipEntity> GetSingle(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_studentmenuskipEntity>> GAPgListView(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
