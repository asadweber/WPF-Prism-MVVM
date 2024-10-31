

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_econtactlistFacadeObjects")]
    public partial interface Igen_econtactlistFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_econtactlistEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_econtactlistEntity>> GetAll(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_econtactlistEntity>> GetAllByPages(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_econtactlistEntity> GetSingle(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_econtactlistEntity>> GAPgListView(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
