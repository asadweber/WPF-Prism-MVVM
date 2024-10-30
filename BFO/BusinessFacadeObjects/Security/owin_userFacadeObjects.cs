


using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security
{
    public sealed partial class owin_userFacadeObjects : BaseFacade, Iowin_userFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userFacadeObjects";
        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public owin_userFacadeObjects()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~owin_userFacadeObjects()
        {
            Dispose(false);
        }
		
		private string SourceOfException(string methodName)
        {
            return "Class name: " + ClassName + " and Method name: " + methodName;
        }
        #endregion
		
		#region Business Facade
		
		#region Save Update Delete List	
		
		async Task<long> Iowin_userFacadeObjects.Delete(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userDataAccess().Delete(owin_user, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.Deleteowin_user"));
            }
        }
		
		async Task<long> Iowin_userFacadeObjects.Update(owin_userEntity owin_user , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().Update(owin_user,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.Updateowin_user"));
            }
		}
		
		async Task<long> Iowin_userFacadeObjects.Add(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().Add(owin_user, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.Addowin_user"));
            }
		}
		
        async Task<long> Iowin_userFacadeObjects.SaveList(List<owin_userEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_user"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userEntity>> Iowin_userFacadeObjects.GetAll(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().GetAll(owin_user, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.GetAllowin_user"));
            }
		}
		
		async Task<IList<owin_userEntity>> Iowin_userFacadeObjects.GetAllByPages(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().GetAllByPages(owin_user,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.GetAllByPagesowin_user"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Iowin_userFacadeObjects.SaveMasterDetowin_lastworkingpage(owin_userEntity Master, List<owin_lastworkingpageEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_lastworkingpageEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_lastworkingpageEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_lastworkingpageEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_lastworkingpage(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_lastworkingpage"));
               }
        }
        
        
        async Task<long> Iowin_userFacadeObjects.SaveMasterDetowin_userclaims(owin_userEntity Master, List<owin_userclaimsEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userclaimsEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userclaimsEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userclaimsEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userclaims(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userclaims"));
               }
        }
        
        
        async Task<long> Iowin_userFacadeObjects.SaveMasterDetowin_userlogintrail(owin_userEntity Master, List<owin_userlogintrailEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userlogintrailEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userlogintrailEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userlogintrailEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userlogintrail(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userlogintrail"));
               }
        }
        
        
        async Task<long> Iowin_userFacadeObjects.SaveMasterDetowin_userpasswordresetinfo(owin_userEntity Master, List<owin_userpasswordresetinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userpasswordresetinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userpasswordresetinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userpasswordresetinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userpasswordresetinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userpasswordresetinfo"));
               }
        }
        
        
        async Task<long> Iowin_userFacadeObjects.SaveMasterDetowin_userprefferencessettings(owin_userEntity Master, List<owin_userprefferencessettingsEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userprefferencessettingsEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userprefferencessettingsEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userprefferencessettingsEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userprefferencessettings(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userprefferencessettings"));
               }
        }
        
        
        async Task<long> Iowin_userFacadeObjects.SaveMasterDetowin_userrole(owin_userEntity Master, List<owin_userroleEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_userroleEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_userroleEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_userroleEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_userDataAccess().SaveMasterDetowin_userrole(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_userrole"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userEntity>  Iowin_userFacadeObjects.GetSingle(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().GetSingle(owin_user,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userEntity Iowin_userFacade.GetSingleowin_user"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userEntity>> Iowin_userFacadeObjects.GAPgListView(owin_userEntity owin_user, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().GAPgListView(owin_user,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userEntity> Iowin_userFacade.GAPgListViewowin_user"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        async Task<long> Iowin_userFacadeObjects.UpdateReviewed(owin_userEntity owin_user, CancellationToken cancellationToken )
		{
			try
			{
				return await DataAccessFactory.Createowin_userDataAccess().UpdateReviewed(owin_user,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userFacade.UpdateReviewedowin_user"));
            }
		}
        #endregion

        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Iowin_userFacadeObjects.GetDataForDropDown(owin_userEntity owin_user, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createowin_userDataAccess().GetDataForDropDown(owin_user, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> Iowin_roleFacade.GetDataForDropDown"));
            }
        }
        #endregion
    }
}