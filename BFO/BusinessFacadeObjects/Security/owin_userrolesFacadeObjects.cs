


using AppConfig.ConfigDAAC;
using BDO.Core.Base;
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
    public sealed partial class owin_userrolesFacadeObjects : BaseFacade, Iowin_userrolesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userrolesFacadeObjects";
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

        public owin_userrolesFacadeObjects()
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

        ~owin_userrolesFacadeObjects()
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
		
		async Task<long> Iowin_userrolesFacadeObjects.Delete(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userrolesDataAccess().Delete(owin_userroles, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userrolesFacade.Deleteowin_userroles"));
            }
        }
		
		async Task<long> Iowin_userrolesFacadeObjects.Update(owin_userrolesEntity owin_userroles , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userrolesDataAccess().Update(owin_userroles,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userrolesFacade.Updateowin_userroles"));
            }
		}
		
		async Task<long> Iowin_userrolesFacadeObjects.Add(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userrolesDataAccess().Add(owin_userroles, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userrolesFacade.Addowin_userroles"));
            }
		}
		
        async Task<long> Iowin_userrolesFacadeObjects.SaveList(List<owin_userrolesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userrolesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userrolesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userrolesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userrolesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userroles"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userrolesEntity>> Iowin_userrolesFacadeObjects.GetAll(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userrolesDataAccess().GetAll(owin_userroles, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userrolesEntity> Iowin_userrolesFacade.GetAllowin_userroles"));
            }
		}
		
		async Task<IList<owin_userrolesEntity>> Iowin_userrolesFacadeObjects.GetAllByPages(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userrolesDataAccess().GetAllByPages(owin_userroles,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userrolesEntity> Iowin_userrolesFacade.GetAllByPagesowin_userroles"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userrolesEntity>  Iowin_userrolesFacadeObjects.GetSingle(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userrolesDataAccess().GetSingle(owin_userroles,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userrolesEntity Iowin_userrolesFacade.GetSingleowin_userroles"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userrolesEntity>> Iowin_userrolesFacadeObjects.GAPgListView(owin_userrolesEntity owin_userroles, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userrolesDataAccess().GAPgListView(owin_userroles,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userrolesEntity> Iowin_userrolesFacade.GAPgListViewowin_userroles"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}