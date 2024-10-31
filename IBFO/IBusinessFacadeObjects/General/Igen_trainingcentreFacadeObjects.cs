

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_trainingcentreFacadeObjects")]
    public partial interface Igen_trainingcentreFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_trainingcentreEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_trainingcentreEntity>> GetAll(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_trainingcentreEntity>> GetAllByPages(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDettran_trainingjoin(gen_trainingcentreEntity Master, List<tran_trainingjoinEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_trainingcentreEntity> GetSingle(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_trainingcentreEntity>> GAPgListView(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken); 
		#endregion
    
    }
}
