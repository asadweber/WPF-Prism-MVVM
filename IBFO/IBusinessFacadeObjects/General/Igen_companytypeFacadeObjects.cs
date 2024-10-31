

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_companytypeFacadeObjects")]
    public partial interface Igen_companytypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_companytypeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_companytypeEntity>> GetAll(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_companytypeEntity>> GetAllByPages(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_companies(gen_companytypeEntity Master, List<gen_companiesEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_previousexperiance(gen_companytypeEntity Master, List<reg_previousexperianceEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_companytypeEntity> GetSingle(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_companytypeEntity>> GAPgListView(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
