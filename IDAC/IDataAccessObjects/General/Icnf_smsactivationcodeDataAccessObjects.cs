using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_smsactivationcodeDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_smsactivationcodeEntity> listAdded, IList<cnf_smsactivationcodeEntity> listUpdated, IList<cnf_smsactivationcodeEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_smsactivationcodeEntity>> GetAll(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
		
        Task<IList<cnf_smsactivationcodeEntity>> GetAllByPages(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetcnf_smsactivationtransection(cnf_smsactivationcodeEntity masterEntity, IList<cnf_smsactivationtransectionEntity> listAdded, IList<cnf_smsactivationtransectionEntity> listUpdated, IList<cnf_smsactivationtransectionEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_smsactivationcodeEntity> GetSingle(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_smsactivationcodeEntity>> GAPgListView(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
