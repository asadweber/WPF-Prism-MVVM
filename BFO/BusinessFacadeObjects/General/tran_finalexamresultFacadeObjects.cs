
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
    public sealed partial class tran_finalexamresultFacadeObjects : BaseFacade, Itran_finalexamresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_finalexamresultFacadeObjects";
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

        public tran_finalexamresultFacadeObjects()
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

        ~tran_finalexamresultFacadeObjects()
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
		
		async Task<long> Itran_finalexamresultFacadeObjects.Delete(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().Delete(tran_finalexamresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_finalexamresultFacade.Deletetran_finalexamresult"));
            }
        }
		
		async Task<long> Itran_finalexamresultFacadeObjects.Update(tran_finalexamresultEntity tran_finalexamresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().Update(tran_finalexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_finalexamresultFacade.Updatetran_finalexamresult"));
            }
		}
		
		async Task<long> Itran_finalexamresultFacadeObjects.Add(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().Add(tran_finalexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_finalexamresultFacade.Addtran_finalexamresult"));
            }
		}
		
        async Task<long> Itran_finalexamresultFacadeObjects.SaveList(List<tran_finalexamresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_finalexamresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_finalexamresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_finalexamresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_finalexamresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_finalexamresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_finalexamresultEntity>> Itran_finalexamresultFacadeObjects.GetAll(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().GetAll(tran_finalexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_finalexamresultEntity> Itran_finalexamresultFacade.GetAlltran_finalexamresult"));
            }
		}
		
		async Task<IList<tran_finalexamresultEntity>> Itran_finalexamresultFacadeObjects.GetAllByPages(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().GetAllByPages(tran_finalexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_finalexamresultEntity> Itran_finalexamresultFacade.GetAllByPagestran_finalexamresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_finalexamresultEntity>  Itran_finalexamresultFacadeObjects.GetSingle(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().GetSingle(tran_finalexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_finalexamresultEntity Itran_finalexamresultFacade.GetSingletran_finalexamresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_finalexamresultEntity>> Itran_finalexamresultFacadeObjects.GAPgListView(tran_finalexamresultEntity tran_finalexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_finalexamresultDataAccess().GAPgListView(tran_finalexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_finalexamresultEntity> Itran_finalexamresultFacade.GAPgListViewtran_finalexamresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}