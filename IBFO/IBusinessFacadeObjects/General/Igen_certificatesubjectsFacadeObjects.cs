﻿

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Igen_certificatesubjectsFacadeObjects")]
    public partial interface Igen_certificatesubjectsFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_certificatesubjectsEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_certificatesubjectsEntity>> GetAll(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_certificatesubjectsEntity>> GetAllByPages(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_certificatesubjectsEntity> GetSingle(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_certificatesubjectsEntity>> GAPgListView(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
