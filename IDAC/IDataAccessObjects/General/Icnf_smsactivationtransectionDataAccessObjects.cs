using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Icnf_smsactivationtransectionDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
		
        Task<long> Update(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
        
        Task<long> Delete(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<cnf_smsactivationtransectionEntity> listAdded, IList<cnf_smsactivationtransectionEntity> listUpdated, IList<cnf_smsactivationtransectionEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<cnf_smsactivationtransectionEntity>> GetAll(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
		
        Task<IList<cnf_smsactivationtransectionEntity>> GetAllByPages(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<cnf_smsactivationtransectionEntity> GetSingle(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<cnf_smsactivationtransectionEntity>> GAPgListView(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
