

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_userrolesFacadeObjects")]
    public partial interface Iowin_userrolesFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_userrolesEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_userrolesEntity>> GetAll(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_userrolesEntity>> GetAllByPages(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_userrolesEntity> GetSingle(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_userrolesEntity>> GAPgListView(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
