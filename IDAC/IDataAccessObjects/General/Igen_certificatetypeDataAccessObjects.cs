using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_certificatetypeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
		
        Task<long> Update(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_certificatetypeEntity> listAdded, IList<gen_certificatetypeEntity> listUpdated, IList<gen_certificatetypeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_certificatetypeEntity>> GetAll(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
		
        Task<IList<gen_certificatetypeEntity>> GetAllByPages(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_certificate(gen_certificatetypeEntity masterEntity, IList<gen_certificateEntity> listAdded, IList<gen_certificateEntity> listUpdated, IList<gen_certificateEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_certificatetypeEntity> GetSingle(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_certificatetypeEntity>> GAPgListView(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
