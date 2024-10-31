
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
    public sealed partial class tran_applyanotherbatchFacadeObjects : BaseFacade, Itran_applyanotherbatchFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_applyanotherbatchFacadeObjects";
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

        public tran_applyanotherbatchFacadeObjects()
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

        ~tran_applyanotherbatchFacadeObjects()
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
		
		async Task<long> Itran_applyanotherbatchFacadeObjects.Delete(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().Delete(tran_applyanotherbatch, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applyanotherbatchFacade.Deletetran_applyanotherbatch"));
            }
        }
		
		async Task<long> Itran_applyanotherbatchFacadeObjects.Update(tran_applyanotherbatchEntity tran_applyanotherbatch , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().Update(tran_applyanotherbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_applyanotherbatchFacade.Updatetran_applyanotherbatch"));
            }
		}
		
		async Task<long> Itran_applyanotherbatchFacadeObjects.Add(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().Add(tran_applyanotherbatch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applyanotherbatchFacade.Addtran_applyanotherbatch"));
            }
		}
		
        async Task<long> Itran_applyanotherbatchFacadeObjects.SaveList(List<tran_applyanotherbatchEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_applyanotherbatchEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_applyanotherbatchEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_applyanotherbatchEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_applyanotherbatch"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_applyanotherbatchEntity>> Itran_applyanotherbatchFacadeObjects.GetAll(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().GetAll(tran_applyanotherbatch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applyanotherbatchEntity> Itran_applyanotherbatchFacade.GetAlltran_applyanotherbatch"));
            }
		}
		
		async Task<IList<tran_applyanotherbatchEntity>> Itran_applyanotherbatchFacadeObjects.GetAllByPages(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().GetAllByPages(tran_applyanotherbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applyanotherbatchEntity> Itran_applyanotherbatchFacade.GetAllByPagestran_applyanotherbatch"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_applyanotherbatchEntity>  Itran_applyanotherbatchFacadeObjects.GetSingle(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().GetSingle(tran_applyanotherbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_applyanotherbatchEntity Itran_applyanotherbatchFacade.GetSingletran_applyanotherbatch"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_applyanotherbatchEntity>> Itran_applyanotherbatchFacadeObjects.GAPgListView(tran_applyanotherbatchEntity tran_applyanotherbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applyanotherbatchDataAccess().GAPgListView(tran_applyanotherbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applyanotherbatchEntity> Itran_applyanotherbatchFacade.GAPgListViewtran_applyanotherbatch"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}