

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_professionFacadeObjects")]
    public partial interface Igen_professionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_professionEntity gen_profession, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_professionEntity gen_profession, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_professionEntity gen_profession, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_professionEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_professionEntity>> GetAll(gen_professionEntity gen_profession, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_professionEntity>> GetAllByPages(gen_professionEntity gen_profession, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandprofession(gen_professionEntity Master, List<gen_batchcandprofessionEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_registrationinfo(gen_professionEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_professionEntity> GetSingle(gen_professionEntity gen_profession, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_professionEntity>> GAPgListView(gen_professionEntity gen_profession, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken); 
		#endregion
    
    }
}
