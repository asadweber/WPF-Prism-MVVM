
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
    public sealed partial class tran_auditresultFacadeObjects : BaseFacade, Itran_auditresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_auditresultFacadeObjects";
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

        public tran_auditresultFacadeObjects()
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

        ~tran_auditresultFacadeObjects()
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
		
		async Task<long> Itran_auditresultFacadeObjects.Delete(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_auditresultDataAccess().Delete(tran_auditresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_auditresultFacade.Deletetran_auditresult"));
            }
        }
		
		async Task<long> Itran_auditresultFacadeObjects.Update(tran_auditresultEntity tran_auditresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_auditresultDataAccess().Update(tran_auditresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_auditresultFacade.Updatetran_auditresult"));
            }
		}
		
		async Task<long> Itran_auditresultFacadeObjects.Add(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_auditresultDataAccess().Add(tran_auditresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_auditresultFacade.Addtran_auditresult"));
            }
		}
		
        async Task<long> Itran_auditresultFacadeObjects.SaveList(List<tran_auditresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_auditresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_auditresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_auditresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_auditresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_auditresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_auditresultEntity>> Itran_auditresultFacadeObjects.GetAll(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_auditresultDataAccess().GetAll(tran_auditresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_auditresultEntity> Itran_auditresultFacade.GetAlltran_auditresult"));
            }
		}
		
		async Task<IList<tran_auditresultEntity>> Itran_auditresultFacadeObjects.GetAllByPages(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_auditresultDataAccess().GetAllByPages(tran_auditresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_auditresultEntity> Itran_auditresultFacade.GetAllByPagestran_auditresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_auditresultEntity>  Itran_auditresultFacadeObjects.GetSingle(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_auditresultDataAccess().GetSingle(tran_auditresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_auditresultEntity Itran_auditresultFacade.GetSingletran_auditresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_auditresultEntity>> Itran_auditresultFacadeObjects.GAPgListView(tran_auditresultEntity tran_auditresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_auditresultDataAccess().GAPgListView(tran_auditresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_auditresultEntity> Itran_auditresultFacade.GAPgListViewtran_auditresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}