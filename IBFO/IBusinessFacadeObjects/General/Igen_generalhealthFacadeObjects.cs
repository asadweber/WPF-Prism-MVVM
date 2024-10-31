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
    [ServiceContract(Name = "Igen_generalhealthFacadeObjects")]
    public partial interface Igen_generalhealthFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<gen_generalhealthEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<gen_generalhealthEntity>> GetAll(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<gen_generalhealthEntity>> GetAllByPages(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<gen_generalhealthEntity> GetSingle(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<gen_generalhealthEntity>> GAPgListView(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
