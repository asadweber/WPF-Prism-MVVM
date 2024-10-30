


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
    public sealed partial class owin_rolepermissionFacadeObjects : BaseFacade, Iowin_rolepermissionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_rolepermissionFacadeObjects";
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

        public owin_rolepermissionFacadeObjects()
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

        ~owin_rolepermissionFacadeObjects()
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
		
		async Task<long> Iowin_rolepermissionFacadeObjects.Delete(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().Delete(owin_rolepermission, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Deleteowin_rolepermission"));
            }
        }
		
		async Task<long> Iowin_rolepermissionFacadeObjects.Update(owin_rolepermissionEntity owin_rolepermission , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().Update(owin_rolepermission,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Updateowin_rolepermission"));
            }
		}
		
		async Task<long> Iowin_rolepermissionFacadeObjects.Add(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().Add(owin_rolepermission, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_rolepermissionFacade.Addowin_rolepermission"));
            }
		}
		
        async Task<long> Iowin_rolepermissionFacadeObjects.SaveList(List<owin_rolepermissionEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_rolepermissionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_rolepermissionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_rolepermissionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_rolepermissionDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_rolepermission"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_rolepermissionEntity>> Iowin_rolepermissionFacadeObjects.GetAll(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().GetAll(owin_rolepermission, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GetAllowin_rolepermission"));
            }
		}
		
		async Task<IList<owin_rolepermissionEntity>> Iowin_rolepermissionFacadeObjects.GetAllByPages(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().GetAllByPages(owin_rolepermission,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GetAllByPagesowin_rolepermission"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_rolepermissionEntity>  Iowin_rolepermissionFacadeObjects.GetSingle(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().GetSingle(owin_rolepermission,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_rolepermissionEntity Iowin_rolepermissionFacade.GetSingleowin_rolepermission"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_rolepermissionEntity>> Iowin_rolepermissionFacadeObjects.GAPgListView(owin_rolepermissionEntity owin_rolepermission, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_rolepermissionDataAccess().GAPgListView(owin_rolepermission,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_rolepermissionEntity> Iowin_rolepermissionFacade.GAPgListViewowin_rolepermission"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}