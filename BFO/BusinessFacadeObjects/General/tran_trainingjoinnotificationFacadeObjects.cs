
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
    public sealed partial class tran_trainingjoinnotificationFacadeObjects : BaseFacade, Itran_trainingjoinnotificationFacadeObjects
    {

        #region Instance Variables
        private string ClassName = "tran_trainingjoinnotificationFacadeObjects";
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

        public tran_trainingjoinnotificationFacadeObjects()
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

        ~tran_trainingjoinnotificationFacadeObjects()
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

        async Task<long> Itran_trainingjoinnotificationFacadeObjects.Delete(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().Delete(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_trainingjoinnotificationFacade.Deletetran_trainingjoinnotification"));
            }
        }

        async Task<long> Itran_trainingjoinnotificationFacadeObjects.Update(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().Update(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_trainingjoinnotificationFacade.Updatetran_trainingjoinnotification"));
            }
        }

        async Task<long> Itran_trainingjoinnotificationFacadeObjects.Add(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().Add(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_trainingjoinnotificationFacade.Addtran_trainingjoinnotification"));
            }
        }

        async Task<long> Itran_trainingjoinnotificationFacadeObjects.SaveList(List<tran_trainingjoinnotificationEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_trainingjoinnotificationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_trainingjoinnotificationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_trainingjoinnotificationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);

                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_trainingjoinnotification"));
            }
        }

        #endregion Save Update Delete List	

        #region GetAll

        async Task<IList<tran_trainingjoinnotificationEntity>> Itran_trainingjoinnotificationFacadeObjects.GetAll(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().GetAll(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_trainingjoinnotificationEntity> Itran_trainingjoinnotificationFacade.GetAlltran_trainingjoinnotification"));
            }
        }

        async Task<IList<tran_trainingjoinnotificationEntity>> Itran_trainingjoinnotificationFacadeObjects.GetAllByPages(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().GetAllByPages(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_trainingjoinnotificationEntity> Itran_trainingjoinnotificationFacade.GetAllByPagestran_trainingjoinnotification"));
            }
        }

        #endregion GetAll

        #region FOR Master Details SAVE	

        #endregion


        #region Simple load Single Row
        async Task<tran_trainingjoinnotificationEntity> Itran_trainingjoinnotificationFacadeObjects.GetSingle(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().GetSingle(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_trainingjoinnotificationEntity Itran_trainingjoinnotificationFacade.GetSingletran_trainingjoinnotification"));
            }
        }
        #endregion

        #region ForListView Paged Method
        async Task<IList<tran_trainingjoinnotificationEntity>> Itran_trainingjoinnotificationFacadeObjects.GAPgListView(tran_trainingjoinnotificationEntity tran_trainingjoinnotification, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createtran_trainingjoinnotificationDataAccess().GAPgListView(tran_trainingjoinnotification, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_trainingjoinnotificationEntity> Itran_trainingjoinnotificationFacade.GAPgListViewtran_trainingjoinnotification"));
            }
        }
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion







        #endregion
    }
}