
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
    public sealed partial class tran_psychoexamresultFacadeObjects : BaseFacade, Itran_psychoexamresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_psychoexamresultFacadeObjects";
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

        public tran_psychoexamresultFacadeObjects()
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

        ~tran_psychoexamresultFacadeObjects()
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
		
		async Task<long> Itran_psychoexamresultFacadeObjects.Delete(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().Delete(tran_psychoexamresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_psychoexamresultFacade.Deletetran_psychoexamresult"));
            }
        }
		
		async Task<long> Itran_psychoexamresultFacadeObjects.Update(tran_psychoexamresultEntity tran_psychoexamresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().Update(tran_psychoexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_psychoexamresultFacade.Updatetran_psychoexamresult"));
            }
		}
		
		async Task<long> Itran_psychoexamresultFacadeObjects.Add(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().Add(tran_psychoexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_psychoexamresultFacade.Addtran_psychoexamresult"));
            }
		}
		
        async Task<long> Itran_psychoexamresultFacadeObjects.SaveList(List<tran_psychoexamresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_psychoexamresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_psychoexamresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_psychoexamresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_psychoexamresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_psychoexamresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_psychoexamresultEntity>> Itran_psychoexamresultFacadeObjects.GetAll(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().GetAll(tran_psychoexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_psychoexamresultEntity> Itran_psychoexamresultFacade.GetAlltran_psychoexamresult"));
            }
		}
		
		async Task<IList<tran_psychoexamresultEntity>> Itran_psychoexamresultFacadeObjects.GetAllByPages(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().GetAllByPages(tran_psychoexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_psychoexamresultEntity> Itran_psychoexamresultFacade.GetAllByPagestran_psychoexamresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_psychoexamresultEntity>  Itran_psychoexamresultFacadeObjects.GetSingle(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().GetSingle(tran_psychoexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_psychoexamresultEntity Itran_psychoexamresultFacade.GetSingletran_psychoexamresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_psychoexamresultEntity>> Itran_psychoexamresultFacadeObjects.GAPgListView(tran_psychoexamresultEntity tran_psychoexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_psychoexamresultDataAccess().GAPgListView(tran_psychoexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_psychoexamresultEntity> Itran_psychoexamresultFacade.GAPgListViewtran_psychoexamresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}