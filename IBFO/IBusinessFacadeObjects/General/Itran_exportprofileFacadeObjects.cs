

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Itran_exportprofileFacadeObjects")]
    public partial interface Itran_exportprofileFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<tran_exportprofileEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<tran_exportprofileEntity>> GetAll(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<tran_exportprofileEntity>> GetAllByPages(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<tran_exportprofileEntity> GetSingle(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<tran_exportprofileEntity>> GAPgListView(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
