

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_userprefferencessettingsFacadeObjects")]
    public partial interface Iowin_userprefferencessettingsFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_userprefferencessettingsEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_userprefferencessettingsEntity>> GetAll(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_userprefferencessettingsEntity>> GetAllByPages(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_userprefferencessettingsEntity> GetSingle(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_userprefferencessettingsEntity>> GAPgListView(owin_userprefferencessettingsEntity owin_userprefferencessettings, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
    }
}
