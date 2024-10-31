using AppConfig.ConfigDAAC;
using BDO.Core.Base;
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
    public sealed partial class tran_finalexamnotificationFacadeObjects : BaseFacade, Itran_finalexamnotificationFacadeObjects
    {

        #region Instance Variables
        private string ClassName = "tran_finalexamnotificationFacadeObjects";
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

        public tran_finalexamnotificationFacadeObjects()
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

        ~tran_finalexamnotificationFacadeObjects()
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

        async Task<long> Itran_finalexamnotificationFacadeObjects.Delete(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().Delete(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_finalexamnotificationFacade.Deletetran_finalexamnotification"));
            }
        }

        async Task<long> Itran_finalexamnotificationFacadeObjects.Update(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().Update(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_finalexamnotificationFacade.Updatetran_finalexamnotification"));
            }
        }

        async Task<long> Itran_finalexamnotificationFacadeObjects.Add(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().Add(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_finalexamnotificationFacade.Addtran_finalexamnotification"));
            }
        }

        async Task<long> Itran_finalexamnotificationFacadeObjects.SaveList(List<tran_finalexamnotificationEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_finalexamnotificationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_finalexamnotificationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_finalexamnotificationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);

                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_finalexamnotification"));
            }
        }

        #endregion Save Update Delete List	

        #region GetAll

        async Task<IList<tran_finalexamnotificationEntity>> Itran_finalexamnotificationFacadeObjects.GetAll(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().GetAll(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_finalexamnotificationEntity> Itran_finalexamnotificationFacade.GetAlltran_finalexamnotification"));
            }
        }

        async Task<IList<tran_finalexamnotificationEntity>> Itran_finalexamnotificationFacadeObjects.GetAllByPages(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().GetAllByPages(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_finalexamnotificationEntity> Itran_finalexamnotificationFacade.GetAllByPagestran_finalexamnotification"));
            }
        }

        #endregion GetAll

        #region FOR Master Details SAVE	

        #endregion


        #region Simple load Single Row
        async Task<tran_finalexamnotificationEntity> Itran_finalexamnotificationFacadeObjects.GetSingle(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().GetSingle(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_finalexamnotificationEntity Itran_finalexamnotificationFacade.GetSingletran_finalexamnotification"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<tran_finalexamnotificationEntity>> Itran_finalexamnotificationFacadeObjects.GAPgListView(tran_finalexamnotificationEntity tran_finalexamnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_finalexamnotificationDataAccess().GAPgListView(tran_finalexamnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_finalexamnotificationEntity> Itran_finalexamnotificationFacade.GAPgListViewtran_finalexamnotification"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion







        #endregion
    }
}