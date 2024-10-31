

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_instituteinfoFacadeObjects")]
    public partial interface Igen_instituteinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_instituteinfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_instituteinfoEntity>> GetAll(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_instituteinfoEntity>> GetAllByPages(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_educationinfo(gen_instituteinfoEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_instituteinfoEntity> GetSingle(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_instituteinfoEntity>> GAPgListView(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken); 
		#endregion
    
    }
}
