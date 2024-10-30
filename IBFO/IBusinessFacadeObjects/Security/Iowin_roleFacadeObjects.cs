

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_roleFacadeObjects")]
    public partial interface Iowin_roleFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_roleEntity owin_role, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_roleEntity owin_role, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_roleEntity owin_role, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_roleEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_roleEntity>> GetAll(owin_roleEntity owin_role, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_roleEntity>> GetAllByPages(owin_roleEntity owin_role, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_roleEntity> GetSingle(owin_roleEntity owin_role, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_roleEntity>> GAPgListView(owin_roleEntity owin_role, CancellationToken cancellationToken);
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(owin_roleEntity owin_role, CancellationToken cancellationToken);
        #endregion
    }
}
