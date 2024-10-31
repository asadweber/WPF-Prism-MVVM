

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_candidatetypeFacadeObjects")]
    public partial interface Igen_candidatetypeFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_candidatetypeEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_candidatetypeEntity>> GetAll(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_candidatetypeEntity>> GetAllByPages(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetgen_batchcandidatetypemap(gen_candidatetypeEntity Master, List<gen_batchcandidatetypemapEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetreg_registrationinfo(gen_candidatetypeEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_candidatetypeEntity> GetSingle(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_candidatetypeEntity>> GAPgListView(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken); 
		#endregion
    
    }
}
