

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_relationshipFacadeObjects")]
    public partial interface Igen_relationshipFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_relationshipEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_relationshipEntity>> GetAll(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_relationshipEntity>> GetAllByPages(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetreg_familly(gen_relationshipEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_relationshipEntity> GetSingle(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_relationshipEntity>> GAPgListView(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken); 
		#endregion
    
    }
}
