

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Icnf_smsactivationtransectionFacadeObjects")]
    public partial interface Icnf_smsactivationtransectionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<cnf_smsactivationtransectionEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<cnf_smsactivationtransectionEntity>> GetAll(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<cnf_smsactivationtransectionEntity>> GetAllByPages(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<cnf_smsactivationtransectionEntity> GetSingle(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<cnf_smsactivationtransectionEntity>> GAPgListView(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
            
    }
}
