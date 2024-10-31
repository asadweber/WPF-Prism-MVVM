
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
    public sealed partial class tran_syexamresultFacadeObjects : BaseFacade, Itran_syexamresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_syexamresultFacadeObjects";
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

        public tran_syexamresultFacadeObjects()
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

        ~tran_syexamresultFacadeObjects()
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
		
		async Task<long> Itran_syexamresultFacadeObjects.Delete(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_syexamresultDataAccess().Delete(tran_syexamresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_syexamresultFacade.Deletetran_syexamresult"));
            }
        }
		
		async Task<long> Itran_syexamresultFacadeObjects.Update(tran_syexamresultEntity tran_syexamresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamresultDataAccess().Update(tran_syexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_syexamresultFacade.Updatetran_syexamresult"));
            }
		}
		
		async Task<long> Itran_syexamresultFacadeObjects.Add(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamresultDataAccess().Add(tran_syexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_syexamresultFacade.Addtran_syexamresult"));
            }
		}
		
        async Task<long> Itran_syexamresultFacadeObjects.SaveList(List<tran_syexamresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_syexamresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_syexamresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_syexamresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_syexamresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_syexamresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_syexamresultEntity>> Itran_syexamresultFacadeObjects.GetAll(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamresultDataAccess().GetAll(tran_syexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_syexamresultEntity> Itran_syexamresultFacade.GetAlltran_syexamresult"));
            }
		}
		
		async Task<IList<tran_syexamresultEntity>> Itran_syexamresultFacadeObjects.GetAllByPages(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamresultDataAccess().GetAllByPages(tran_syexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_syexamresultEntity> Itran_syexamresultFacade.GetAllByPagestran_syexamresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_syexamresultEntity>  Itran_syexamresultFacadeObjects.GetSingle(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamresultDataAccess().GetSingle(tran_syexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_syexamresultEntity Itran_syexamresultFacade.GetSingletran_syexamresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_syexamresultEntity>> Itran_syexamresultFacadeObjects.GAPgListView(tran_syexamresultEntity tran_syexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamresultDataAccess().GAPgListView(tran_syexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_syexamresultEntity> Itran_syexamresultFacade.GAPgListViewtran_syexamresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}