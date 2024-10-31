
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
    public sealed partial class tran_notificationfiledetFacadeObjects : BaseFacade, Itran_notificationfiledetFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_notificationfiledetFacadeObjects";
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

        public tran_notificationfiledetFacadeObjects()
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

        ~tran_notificationfiledetFacadeObjects()
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
		
		async Task<long> Itran_notificationfiledetFacadeObjects.Delete(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().Delete(tran_notificationfiledet, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationfiledetFacade.Deletetran_notificationfiledet"));
            }
        }
		
		async Task<long> Itran_notificationfiledetFacadeObjects.Update(tran_notificationfiledetEntity tran_notificationfiledet , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().Update(tran_notificationfiledet,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_notificationfiledetFacade.Updatetran_notificationfiledet"));
            }
		}
		
		async Task<long> Itran_notificationfiledetFacadeObjects.Add(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().Add(tran_notificationfiledet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationfiledetFacade.Addtran_notificationfiledet"));
            }
		}
		
        async Task<long> Itran_notificationfiledetFacadeObjects.SaveList(List<tran_notificationfiledetEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_notificationfiledetEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_notificationfiledetEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_notificationfiledetEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_notificationfiledetDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_notificationfiledet"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_notificationfiledetEntity>> Itran_notificationfiledetFacadeObjects.GetAll(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().GetAll(tran_notificationfiledet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfiledetEntity> Itran_notificationfiledetFacade.GetAlltran_notificationfiledet"));
            }
		}
		
		async Task<IList<tran_notificationfiledetEntity>> Itran_notificationfiledetFacadeObjects.GetAllByPages(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().GetAllByPages(tran_notificationfiledet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfiledetEntity> Itran_notificationfiledetFacade.GetAllByPagestran_notificationfiledet"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_notificationfiledetEntity>  Itran_notificationfiledetFacadeObjects.GetSingle(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().GetSingle(tran_notificationfiledet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_notificationfiledetEntity Itran_notificationfiledetFacade.GetSingletran_notificationfiledet"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_notificationfiledetEntity>> Itran_notificationfiledetFacadeObjects.GAPgListView(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfiledetDataAccess().GAPgListView(tran_notificationfiledet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfiledetEntity> Itran_notificationfiledetFacade.GAPgListViewtran_notificationfiledet"));
            }
		}
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion



        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Itran_notificationfiledetFacadeObjects.GetDataForDropDown(tran_notificationfiledetEntity tran_notificationfiledet, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_notificationfiledetDataAccess().GetDataForDropDown(tran_notificationfiledet, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfiledetEntity> Itran_notificationfiledetFacade.GetDataForDropDown"));
            }
        }
        #endregion



        #endregion
    }
}