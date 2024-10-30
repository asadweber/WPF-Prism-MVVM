

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_userlogintrailFacadeObjects")]
    public partial interface Iowin_userlogintrailFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_userlogintrailEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_userlogintrailEntity>> GetAll(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_userlogintrailEntity>> GetAllByPages(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_userlogintrailEntity> GetSingle(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_userlogintrailEntity>> GAPgListView(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
