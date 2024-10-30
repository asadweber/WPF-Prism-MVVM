

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_rolepermissionFacadeObjects")]
    public partial interface Iowin_rolepermissionFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_rolepermissionEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_rolepermissionEntity>> GetAll(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_rolepermissionEntity>> GetAllByPages(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_rolepermissionEntity> GetSingle(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_rolepermissionEntity>> GAPgListView(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
