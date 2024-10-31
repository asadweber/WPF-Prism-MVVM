
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
    public sealed partial class tran_notificationfileFacadeObjects : BaseFacade, Itran_notificationfileFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_notificationfileFacadeObjects";
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

        public tran_notificationfileFacadeObjects()
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

        ~tran_notificationfileFacadeObjects()
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
		
		async Task<long> Itran_notificationfileFacadeObjects.Delete(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_notificationfileDataAccess().Delete(tran_notificationfile, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationfileFacade.Deletetran_notificationfile"));
            }
        }
		
		async Task<long> Itran_notificationfileFacadeObjects.Update(tran_notificationfileEntity tran_notificationfile , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfileDataAccess().Update(tran_notificationfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_notificationfileFacade.Updatetran_notificationfile"));
            }
		}
		
		async Task<long> Itran_notificationfileFacadeObjects.Add(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfileDataAccess().Add(tran_notificationfile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationfileFacade.Addtran_notificationfile"));
            }
		}
		
        async Task<long> Itran_notificationfileFacadeObjects.SaveList(List<tran_notificationfileEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_notificationfileEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_notificationfileEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_notificationfileEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_notificationfileDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_notificationfile"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_notificationfileEntity>> Itran_notificationfileFacadeObjects.GetAll(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfileDataAccess().GetAll(tran_notificationfile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfileEntity> Itran_notificationfileFacade.GetAlltran_notificationfile"));
            }
		}
		
		async Task<IList<tran_notificationfileEntity>> Itran_notificationfileFacadeObjects.GetAllByPages(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfileDataAccess().GetAllByPages(tran_notificationfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfileEntity> Itran_notificationfileFacade.GetAllByPagestran_notificationfile"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_notificationfileEntity>  Itran_notificationfileFacadeObjects.GetSingle(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfileDataAccess().GetSingle(tran_notificationfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_notificationfileEntity Itran_notificationfileFacade.GetSingletran_notificationfile"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_notificationfileEntity>> Itran_notificationfileFacadeObjects.GAPgListView(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationfileDataAccess().GAPgListView(tran_notificationfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfileEntity> Itran_notificationfileFacade.GAPgListViewtran_notificationfile"));
            }
		}
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion


        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Itran_notificationfileFacadeObjects.GetDataForDropDown(tran_notificationfileEntity tran_notificationfile, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_notificationfileDataAccess().GetDataForDropDown(tran_notificationfile, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationfileEntity> Itran_notificationfileFacade.GetDataForDropDown"));
            }
        }
        #endregion




        #endregion
    }
}