

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_userclaimsFacadeObjects")]
    public partial interface Iowin_userclaimsFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_userclaimsEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_userclaimsEntity>> GetAll(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_userclaimsEntity>> GetAllByPages(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_userclaimsEntity> GetSingle(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_userclaimsEntity>> GAPgListView(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
