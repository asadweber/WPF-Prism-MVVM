using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_faqDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_faqEntity gen_faq, CancellationToken cancellationToken);
		
        Task<long> Update(gen_faqEntity gen_faq, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_faqEntity gen_faq, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_faqEntity> listAdded, IList<gen_faqEntity> listUpdated, IList<gen_faqEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_faqEntity>> GetAll(gen_faqEntity gen_faq, CancellationToken cancellationToken);
		
        Task<IList<gen_faqEntity>> GetAllByPages(gen_faqEntity gen_faq, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_faqEntity> GetSingle(gen_faqEntity gen_faq, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_faqEntity>> GAPgListView(gen_faqEntity gen_faq, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
               
        
        
        
        
    }
}
