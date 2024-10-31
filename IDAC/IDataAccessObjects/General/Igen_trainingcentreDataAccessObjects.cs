using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_trainingcentreDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
		
        Task<long> Update(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_trainingcentreEntity> listAdded, IList<gen_trainingcentreEntity> listUpdated, IList<gen_trainingcentreEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_trainingcentreEntity>> GetAll(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
		
        Task<IList<gen_trainingcentreEntity>> GetAllByPages(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDettran_trainingjoin(gen_trainingcentreEntity masterEntity, IList<tran_trainingjoinEntity> listAdded, IList<tran_trainingjoinEntity> listUpdated, IList<tran_trainingjoinEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_trainingcentreEntity> GetSingle(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_trainingcentreEntity>> GAPgListView(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
