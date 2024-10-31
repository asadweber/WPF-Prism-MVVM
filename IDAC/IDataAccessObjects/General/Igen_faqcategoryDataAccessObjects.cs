using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_faqcategoryDataAccessObjects
    {
		 
		#region Save Update Delete List Single Entity	
        
        Task<long> Add(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
		
        Task<long> Update(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
        
        Task<long> Delete(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
		
        Task<long> SaveList(IList<gen_faqcategoryEntity> listAdded, IList<gen_faqcategoryEntity> listUpdated, IList<gen_faqcategoryEntity> listDeleted, CancellationToken cancellationToken);
        
		#endregion Save Update Delete List
		
		
		#region GetAll	
		Task<IList<gen_faqcategoryEntity>> GetAll(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
		
        Task<IList<gen_faqcategoryEntity>> GetAllByPages(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
        
		#endregion GetAll
		
		#region SaveMasterDetails
        Task<long> SaveMasterDetgen_faq(gen_faqcategoryEntity masterEntity, IList<gen_faqEntity> listAdded, IList<gen_faqEntity> listUpdated, IList<gen_faqEntity> listDeleted, CancellationToken cancellationToken);

        #endregion SaveMasterDetails
        
         #region Simple load Single Row
         Task<gen_faqcategoryEntity> GetSingle(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         Task<IList<gen_faqcategoryEntity>> GAPgListView(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion        
        
        
        #region for Dropdown 
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
