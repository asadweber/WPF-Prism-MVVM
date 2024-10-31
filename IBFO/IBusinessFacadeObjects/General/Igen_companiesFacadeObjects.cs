

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_companiesFacadeObjects")]
    public partial interface Igen_companiesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_companiesEntity gen_companies, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_companiesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_companiesEntity>> GetAll(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_companiesEntity>> GetAllByPages(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_companiesEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_previousexperiance(gen_companiesEntity Master, List<reg_previousexperianceEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_companiesEntity> GetSingle(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_companiesEntity>> GAPgListView(gen_companiesEntity gen_companies, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_companiesEntity gen_companies, CancellationToken cancellationToken); 
		#endregion
    
    }
}
