

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_userroleFacadeObjects")]
    public partial interface Iowin_userroleFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_userroleEntity owin_userrole, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_userroleEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_userroleEntity>> GetAll(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_userroleEntity>> GetAllByPages(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_userroleEntity> GetSingle(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_userroleEntity>> GAPgListView(owin_userroleEntity owin_userrole, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
