

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_formactionFacadeObjects")]
    public partial interface Iowin_formactionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_formactionEntity owin_formaction, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_formactionEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_formactionEntity>> GetAll(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_formactionEntity>> GetAllByPages(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetowin_formaction(owin_formactionEntity Master, List<owin_formactionEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_rolepermission(owin_formactionEntity Master, List<owin_rolepermissionEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_formactionEntity> GetSingle(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_formactionEntity>> GAPgListView(owin_formactionEntity owin_formaction, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
