

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    public partial interface Igen_newsFacadeObjects 
    { 
		#region Save Update Delete List 
		
		[OperationContract]
        Task<long> Add_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);
        		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_newsEntity>> GetAll_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Simple load Single Row
        [OperationContract]
        Task<gen_newsEntity> GetSingle_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken);
         #endregion 
    }
}
