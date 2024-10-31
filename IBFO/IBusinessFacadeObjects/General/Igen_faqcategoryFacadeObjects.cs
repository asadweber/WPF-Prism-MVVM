

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_faqcategoryFacadeObjects")]
    public partial interface Igen_faqcategoryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_faqcategoryEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_faqcategoryEntity>> GetAll(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_faqcategoryEntity>> GetAllByPages(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_faq(gen_faqcategoryEntity Master, List<gen_faqEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_faqcategoryEntity> GetSingle(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_faqcategoryEntity>> GAPgListView(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken); 
		#endregion
    
    }
}
