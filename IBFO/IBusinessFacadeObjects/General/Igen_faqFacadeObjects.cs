

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_faqFacadeObjects")]
    public partial interface Igen_faqFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_faqEntity gen_faq, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_faqEntity gen_faq, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_faqEntity gen_faq, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_faqEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_faqEntity>> GetAll(gen_faqEntity gen_faq, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_faqEntity>> GetAllByPages(gen_faqEntity gen_faq, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_faqEntity> GetSingle(gen_faqEntity gen_faq, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_faqEntity>> GAPgListView(gen_faqEntity gen_faq, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
