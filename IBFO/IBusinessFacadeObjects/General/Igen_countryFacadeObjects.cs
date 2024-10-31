

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_countryFacadeObjects")]
    public partial interface Igen_countryFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_countryEntity gen_country, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_countryEntity gen_country, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_countryEntity gen_country, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_countryEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_countryEntity>> GetAll(gen_countryEntity gen_country, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_countryEntity>> GetAllByPages(gen_countryEntity gen_country, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_countrycity(gen_countryEntity Master, List<gen_countrycityEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_countryclass(gen_countryEntity Master, List<gen_countryclassEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetgen_instituteinfo(gen_countryEntity Master, List<gen_instituteinfoEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_educationinfo(gen_countryEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_countryEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_countryEntity> GetSingle(gen_countryEntity gen_country, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_countryEntity>> GAPgListView(gen_countryEntity gen_country, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_countryEntity gen_country, CancellationToken cancellationToken); 
		#endregion
    
    }
}
