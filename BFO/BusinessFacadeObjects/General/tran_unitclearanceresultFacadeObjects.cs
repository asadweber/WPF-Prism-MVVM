
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
    public sealed partial class tran_unitclearanceresultFacadeObjects : BaseFacade, Itran_unitclearanceresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_unitclearanceresultFacadeObjects";
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

        public tran_unitclearanceresultFacadeObjects()
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

        ~tran_unitclearanceresultFacadeObjects()
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
		
		async Task<long> Itran_unitclearanceresultFacadeObjects.Delete(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().Delete(tran_unitclearanceresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_unitclearanceresultFacade.Deletetran_unitclearanceresult"));
            }
        }
		
		async Task<long> Itran_unitclearanceresultFacadeObjects.Update(tran_unitclearanceresultEntity tran_unitclearanceresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().Update(tran_unitclearanceresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_unitclearanceresultFacade.Updatetran_unitclearanceresult"));
            }
		}
		
		async Task<long> Itran_unitclearanceresultFacadeObjects.Add(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().Add(tran_unitclearanceresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_unitclearanceresultFacade.Addtran_unitclearanceresult"));
            }
		}
		
        async Task<long> Itran_unitclearanceresultFacadeObjects.SaveList(List<tran_unitclearanceresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_unitclearanceresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_unitclearanceresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_unitclearanceresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_unitclearanceresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_unitclearanceresultEntity>> Itran_unitclearanceresultFacadeObjects.GetAll(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().GetAll(tran_unitclearanceresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_unitclearanceresultEntity> Itran_unitclearanceresultFacade.GetAlltran_unitclearanceresult"));
            }
		}
		
		async Task<IList<tran_unitclearanceresultEntity>> Itran_unitclearanceresultFacadeObjects.GetAllByPages(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().GetAllByPages(tran_unitclearanceresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_unitclearanceresultEntity> Itran_unitclearanceresultFacade.GetAllByPagestran_unitclearanceresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_unitclearanceresultEntity>  Itran_unitclearanceresultFacadeObjects.GetSingle(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().GetSingle(tran_unitclearanceresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_unitclearanceresultEntity Itran_unitclearanceresultFacade.GetSingletran_unitclearanceresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_unitclearanceresultEntity>> Itran_unitclearanceresultFacadeObjects.GAPgListView(tran_unitclearanceresultEntity tran_unitclearanceresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_unitclearanceresultDataAccess().GAPgListView(tran_unitclearanceresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_unitclearanceresultEntity> Itran_unitclearanceresultFacade.GAPgListViewtran_unitclearanceresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}