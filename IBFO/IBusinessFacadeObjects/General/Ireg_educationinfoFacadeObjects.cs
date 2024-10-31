

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Ireg_educationinfoFacadeObjects")]
    public partial interface Ireg_educationinfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<reg_educationinfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<reg_educationinfoEntity>> GetAll(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<reg_educationinfoEntity>> GetAllByPages(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<reg_educationinfoEntity> GetSingle(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<reg_educationinfoEntity>> GAPgListView(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
