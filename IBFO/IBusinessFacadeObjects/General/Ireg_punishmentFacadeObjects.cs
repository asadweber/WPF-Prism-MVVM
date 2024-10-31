

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_punishmentFacadeObjects")]
    public partial interface Ireg_punishmentFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_punishmentEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_punishmentEntity>> GetAll(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_punishmentEntity>> GetAllByPages(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_punishmentEntity> GetSingle(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_punishmentEntity>> GAPgListView(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
