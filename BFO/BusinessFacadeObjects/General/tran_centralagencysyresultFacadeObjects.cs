
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
    public sealed partial class tran_centralagencysyresultFacadeObjects : BaseFacade, Itran_centralagencysyresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_centralagencysyresultFacadeObjects";
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

        public tran_centralagencysyresultFacadeObjects()
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

        ~tran_centralagencysyresultFacadeObjects()
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
		
		async Task<long> Itran_centralagencysyresultFacadeObjects.Delete(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().Delete(tran_centralagencysyresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_centralagencysyresultFacade.Deletetran_centralagencysyresult"));
            }
        }
		
		async Task<long> Itran_centralagencysyresultFacadeObjects.Update(tran_centralagencysyresultEntity tran_centralagencysyresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().Update(tran_centralagencysyresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_centralagencysyresultFacade.Updatetran_centralagencysyresult"));
            }
		}
		
		async Task<long> Itran_centralagencysyresultFacadeObjects.Add(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().Add(tran_centralagencysyresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_centralagencysyresultFacade.Addtran_centralagencysyresult"));
            }
		}
		
        async Task<long> Itran_centralagencysyresultFacadeObjects.SaveList(List<tran_centralagencysyresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_centralagencysyresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_centralagencysyresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_centralagencysyresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_centralagencysyresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_centralagencysyresultEntity>> Itran_centralagencysyresultFacadeObjects.GetAll(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().GetAll(tran_centralagencysyresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_centralagencysyresultEntity> Itran_centralagencysyresultFacade.GetAlltran_centralagencysyresult"));
            }
		}
		
		async Task<IList<tran_centralagencysyresultEntity>> Itran_centralagencysyresultFacadeObjects.GetAllByPages(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().GetAllByPages(tran_centralagencysyresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_centralagencysyresultEntity> Itran_centralagencysyresultFacade.GetAllByPagestran_centralagencysyresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_centralagencysyresultEntity>  Itran_centralagencysyresultFacadeObjects.GetSingle(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().GetSingle(tran_centralagencysyresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_centralagencysyresultEntity Itran_centralagencysyresultFacade.GetSingletran_centralagencysyresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_centralagencysyresultEntity>> Itran_centralagencysyresultFacadeObjects.GAPgListView(tran_centralagencysyresultEntity tran_centralagencysyresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_centralagencysyresultDataAccess().GAPgListView(tran_centralagencysyresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_centralagencysyresultEntity> Itran_centralagencysyresultFacade.GAPgListViewtran_centralagencysyresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}