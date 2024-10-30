

using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;


namespace IBFO.Core.IBusinessFacadeObjects.Security
{
    [ServiceContract(Name = "Iowin_userFacadeObjects")]
    public partial interface Iowin_userFacadeObjects : IDisposable
    { 
		#region Save Update Delete List 
		
		
		[OperationContract]
        Task<long> Add(owin_userEntity owin_user, CancellationToken cancellationToken);
        
		[OperationContract]
		Task<long> Update(owin_userEntity owin_user, CancellationToken cancellationToken );
		
		[OperationContract]
		Task<long> Delete(owin_userEntity owin_user, CancellationToken cancellationToken);
        
        [OperationContract]
        Task<long> SaveList(List<owin_userEntity> list , CancellationToken cancellationToken);
		
		
		#endregion Save Update Delete List
		
		#region GetAll	
		
		[OperationContract]
        Task<IList<owin_userEntity>> GetAll(owin_userEntity owin_user, CancellationToken cancellationToken);
		
		[OperationContract]
        Task<IList<owin_userEntity>> GetAllByPages(owin_userEntity owin_user, CancellationToken cancellationToken);
     
		#endregion GetAll
		
        #region Save Master/Details	
        
        [OperationContract]
        Task<long> SaveMasterDetowin_lastworkingpage(owin_userEntity Master, List<owin_lastworkingpageEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_userclaims(owin_userEntity Master, List<owin_userclaimsEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_userlogintrail(owin_userEntity Master, List<owin_userlogintrailEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_userpasswordresetinfo(owin_userEntity Master, List<owin_userpasswordresetinfoEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_userprefferencessettings(owin_userEntity Master, List<owin_userprefferencessettingsEntity> DetailList, CancellationToken cancellationToken);

        [OperationContract]
        Task<long> SaveMasterDetowin_userrole(owin_userEntity Master, List<owin_userroleEntity> DetailList, CancellationToken cancellationToken);

        #endregion Save Master/Details	
        
        #region Simple load Single Row
        [OperationContract]
        Task<owin_userEntity> GetSingle(owin_userEntity owin_user, CancellationToken cancellationToken);
         #endregion 
         
         #region ForListView Paged Method
         [OperationContract]
         Task<IList<owin_userEntity>> GAPgListView(owin_userEntity owin_user, CancellationToken cancellationToken);
         #endregion
         
        #region Extras Reviewed, Published, Archived
        [OperationContract]
        Task<long> UpdateReviewed(owin_userEntity owin_user, CancellationToken cancellationToken);
        #endregion 

        #region for Dropdown 
        [OperationContract]
        Task<IList<gen_dropdownEntity>> GetDataForDropDown(owin_userEntity owin_user, CancellationToken cancellationToken);
        #endregion
    }
}
