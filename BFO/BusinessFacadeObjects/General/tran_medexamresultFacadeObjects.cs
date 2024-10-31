
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
    public sealed partial class tran_medexamresultFacadeObjects : BaseFacade, Itran_medexamresultFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_medexamresultFacadeObjects";
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

        public tran_medexamresultFacadeObjects()
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

        ~tran_medexamresultFacadeObjects()
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
		
		async Task<long> Itran_medexamresultFacadeObjects.Delete(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_medexamresultDataAccess().Delete(tran_medexamresult, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_medexamresultFacade.Deletetran_medexamresult"));
            }
        }
		
		async Task<long> Itran_medexamresultFacadeObjects.Update(tran_medexamresultEntity tran_medexamresult , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamresultDataAccess().Update(tran_medexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_medexamresultFacade.Updatetran_medexamresult"));
            }
		}
		
		async Task<long> Itran_medexamresultFacadeObjects.Add(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamresultDataAccess().Add(tran_medexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_medexamresultFacade.Addtran_medexamresult"));
            }
		}
		
        async Task<long> Itran_medexamresultFacadeObjects.SaveList(List<tran_medexamresultEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_medexamresultEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_medexamresultEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_medexamresultEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_medexamresultDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_medexamresult"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_medexamresultEntity>> Itran_medexamresultFacadeObjects.GetAll(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamresultDataAccess().GetAll(tran_medexamresult, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_medexamresultEntity> Itran_medexamresultFacade.GetAlltran_medexamresult"));
            }
		}
		
		async Task<IList<tran_medexamresultEntity>> Itran_medexamresultFacadeObjects.GetAllByPages(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamresultDataAccess().GetAllByPages(tran_medexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_medexamresultEntity> Itran_medexamresultFacade.GetAllByPagestran_medexamresult"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_medexamresultEntity>  Itran_medexamresultFacadeObjects.GetSingle(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamresultDataAccess().GetSingle(tran_medexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_medexamresultEntity Itran_medexamresultFacade.GetSingletran_medexamresult"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_medexamresultEntity>> Itran_medexamresultFacadeObjects.GAPgListView(tran_medexamresultEntity tran_medexamresult, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamresultDataAccess().GAPgListView(tran_medexamresult,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_medexamresultEntity> Itran_medexamresultFacade.GAPgListViewtran_medexamresult"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}