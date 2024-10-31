

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;

namespace IBFO.Core.IBusinessFacadeObjects.General
{
    [ServiceContract(Name = "Iowin_forminfoFacadeObjects")]
    public partial interface Iowin_forminfoFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_forminfoEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_forminfoEntity>> GetAll(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_forminfoEntity>> GetAllByPages(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        
        [OperationContract]
        Task<long> SaveMasterDetowin_formaction(owin_forminfoEntity Master, List<owin_formactionEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_rolepermission(owin_forminfoEntity Master, List<owin_rolepermissionEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_forminfoEntity> GetSingle(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_forminfoEntity>> GAPgListView(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        #endregion 
        
        
        #region for Dropdown 
		[OperationContract]
		Task<IList<gen_dropdownEntity>> GetDataForDropDown(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken); 
		#endregion
    
    }
}
