


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
    public sealed partial class owin_userstatuschangehistoryFacadeObjects : BaseFacade, Iowin_userstatuschangehistoryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userstatuschangehistoryFacadeObjects";
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

        public owin_userstatuschangehistoryFacadeObjects()
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

        ~owin_userstatuschangehistoryFacadeObjects()
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
		
		async Task<long> Iowin_userstatuschangehistoryFacadeObjects.Delete(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().Delete(owin_userstatuschangehistory, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userstatuschangehistoryFacade.Deleteowin_userstatuschangehistory"));
            }
        }
		
		async Task<long> Iowin_userstatuschangehistoryFacadeObjects.Update(owin_userstatuschangehistoryEntity owin_userstatuschangehistory , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().Update(owin_userstatuschangehistory,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userstatuschangehistoryFacade.Updateowin_userstatuschangehistory"));
            }
		}
		
		async Task<long> Iowin_userstatuschangehistoryFacadeObjects.Add(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().Add(owin_userstatuschangehistory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userstatuschangehistoryFacade.Addowin_userstatuschangehistory"));
            }
		}
		
        async Task<long> Iowin_userstatuschangehistoryFacadeObjects.SaveList(List<owin_userstatuschangehistoryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userstatuschangehistoryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userstatuschangehistoryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userstatuschangehistoryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userstatuschangehistory"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userstatuschangehistoryEntity>> Iowin_userstatuschangehistoryFacadeObjects.GetAll(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().GetAll(owin_userstatuschangehistory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userstatuschangehistoryEntity> Iowin_userstatuschangehistoryFacade.GetAllowin_userstatuschangehistory"));
            }
		}
		
		async Task<IList<owin_userstatuschangehistoryEntity>> Iowin_userstatuschangehistoryFacadeObjects.GetAllByPages(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().GetAllByPages(owin_userstatuschangehistory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userstatuschangehistoryEntity> Iowin_userstatuschangehistoryFacade.GetAllByPagesowin_userstatuschangehistory"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userstatuschangehistoryEntity>  Iowin_userstatuschangehistoryFacadeObjects.GetSingle(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().GetSingle(owin_userstatuschangehistory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userstatuschangehistoryEntity Iowin_userstatuschangehistoryFacade.GetSingleowin_userstatuschangehistory"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userstatuschangehistoryEntity>> Iowin_userstatuschangehistoryFacadeObjects.GAPgListView(owin_userstatuschangehistoryEntity owin_userstatuschangehistory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userstatuschangehistoryDataAccess().GAPgListView(owin_userstatuschangehistory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userstatuschangehistoryEntity> Iowin_userstatuschangehistoryFacade.GAPgListViewowin_userstatuschangehistory"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}