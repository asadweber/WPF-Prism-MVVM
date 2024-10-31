

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_usefullinkFacadeObjects")]
    public partial interface Igen_usefullinkFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_usefullinkEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_usefullinkEntity>> GetAll(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_usefullinkEntity>> GetAllByPages(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_usefullinkEntity> GetSingle(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_usefullinkEntity>> GAPgListView(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
