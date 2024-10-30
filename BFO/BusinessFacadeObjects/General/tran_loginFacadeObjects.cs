
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.General
{
    public sealed partial class tran_loginFacadeObjects : BaseFacade, Itran_loginFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_loginFacadeObjects";
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

        public tran_loginFacadeObjects()
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

        ~tran_loginFacadeObjects()
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
		
		async Task<long> Itran_loginFacadeObjects.Delete(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_loginDataAccess().Delete(tran_login, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_loginFacade.Deletetran_login"));
            }
        }
		
		async Task<long> Itran_loginFacadeObjects.Update(tran_loginEntity tran_login , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_loginDataAccess().Update(tran_login,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_loginFacade.Updatetran_login"));
            }
		}
		
		async Task<long> Itran_loginFacadeObjects.Add(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_loginDataAccess().Add(tran_login, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_loginFacade.Addtran_login"));
            }
		}
		
        async Task<long> Itran_loginFacadeObjects.SaveList(List<tran_loginEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_loginEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_loginEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_loginEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_loginDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_login"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_loginEntity>> Itran_loginFacadeObjects.GetAll(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_loginDataAccess().GetAll(tran_login, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_loginEntity> Itran_loginFacade.GetAlltran_login"));
            }
		}
		
		async Task<IList<tran_loginEntity>> Itran_loginFacadeObjects.GetAllByPages(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_loginDataAccess().GetAllByPages(tran_login,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_loginEntity> Itran_loginFacade.GetAllByPagestran_login"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_loginEntity>  Itran_loginFacadeObjects.GetSingle(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_loginDataAccess().GetSingle(tran_login,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_loginEntity Itran_loginFacade.GetSingletran_login"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_loginEntity>> Itran_loginFacadeObjects.GAPgListView(tran_loginEntity tran_login, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_loginDataAccess().GAPgListView(tran_login,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_loginEntity> Itran_loginFacade.GAPgListViewtran_login"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}