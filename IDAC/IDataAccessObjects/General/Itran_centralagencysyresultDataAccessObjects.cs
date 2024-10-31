using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Itran_centralagencysyresultDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
		
        Task<long> Update(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
        
        Task<long> Delete(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<tran_centralagencysyresultEntity> listAdded, IList<tran_centralagencysyresultEntity> listUpdated, IList<tran_centralagencysyresultEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<tran_centralagencysyresultEntity>> GetAll(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
		
        Task<IList<tran_centralagencysyresultEntity>> GetAllByPages(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<tran_centralagencysyresultEntity> GetSingle(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<tran_centralagencysyresultEntity>> GAPgListView(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
