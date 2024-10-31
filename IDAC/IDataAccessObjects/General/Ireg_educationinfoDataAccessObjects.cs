using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Ireg_educationinfoDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
		
        Task<long> Update(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
        Task<long> Delete(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<reg_educationinfoEntity> listAdded, IList<reg_educationinfoEntity> listUpdated, IList<reg_educationinfoEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<reg_educationinfoEntity>> GetAll(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
		
        Task<IList<reg_educationinfoEntity>> GetAllByPages(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<reg_educationinfoEntity> GetSingle(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<reg_educationinfoEntity>> GAPgListView(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
