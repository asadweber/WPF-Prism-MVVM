
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
    public sealed partial class tran_syexamnotificationFacadeObjects : BaseFacade, Itran_syexamnotificationFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_syexamnotificationFacadeObjects";
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

        public tran_syexamnotificationFacadeObjects()
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

        ~tran_syexamnotificationFacadeObjects()
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
		
		async Task<long> Itran_syexamnotificationFacadeObjects.Delete(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().Delete(tran_syexamnotification, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_syexamnotificationFacade.Deletetran_syexamnotification"));
            }
        }
		
		async Task<long> Itran_syexamnotificationFacadeObjects.Update(tran_syexamnotificationEntity tran_syexamnotification , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().Update(tran_syexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_syexamnotificationFacade.Updatetran_syexamnotification"));
            }
		}
		
		async Task<long> Itran_syexamnotificationFacadeObjects.Add(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().Add(tran_syexamnotification, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_syexamnotificationFacade.Addtran_syexamnotification"));
            }
		}
		
        async Task<long> Itran_syexamnotificationFacadeObjects.SaveList(List<tran_syexamnotificationEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_syexamnotificationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_syexamnotificationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_syexamnotificationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_syexamnotificationDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_syexamnotification"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_syexamnotificationEntity>> Itran_syexamnotificationFacadeObjects.GetAll(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().GetAll(tran_syexamnotification, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_syexamnotificationEntity> Itran_syexamnotificationFacade.GetAlltran_syexamnotification"));
            }
		}
		
		async Task<IList<tran_syexamnotificationEntity>> Itran_syexamnotificationFacadeObjects.GetAllByPages(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().GetAllByPages(tran_syexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_syexamnotificationEntity> Itran_syexamnotificationFacade.GetAllByPagestran_syexamnotification"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_syexamnotificationEntity>  Itran_syexamnotificationFacadeObjects.GetSingle(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().GetSingle(tran_syexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_syexamnotificationEntity Itran_syexamnotificationFacade.GetSingletran_syexamnotification"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_syexamnotificationEntity>> Itran_syexamnotificationFacadeObjects.GAPgListView(tran_syexamnotificationEntity tran_syexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_syexamnotificationDataAccess().GAPgListView(tran_syexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_syexamnotificationEntity> Itran_syexamnotificationFacade.GAPgListViewtran_syexamnotification"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}