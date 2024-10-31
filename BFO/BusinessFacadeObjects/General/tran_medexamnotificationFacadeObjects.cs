
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
    public sealed partial class tran_medexamnotificationFacadeObjects : BaseFacade, Itran_medexamnotificationFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_medexamnotificationFacadeObjects";
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

        public tran_medexamnotificationFacadeObjects()
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

        ~tran_medexamnotificationFacadeObjects()
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
		
		async Task<long> Itran_medexamnotificationFacadeObjects.Delete(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().Delete(tran_medexamnotification, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_medexamnotificationFacade.Deletetran_medexamnotification"));
            }
        }
		
		async Task<long> Itran_medexamnotificationFacadeObjects.Update(tran_medexamnotificationEntity tran_medexamnotification , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().Update(tran_medexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_medexamnotificationFacade.Updatetran_medexamnotification"));
            }
		}
		
		async Task<long> Itran_medexamnotificationFacadeObjects.Add(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().Add(tran_medexamnotification, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_medexamnotificationFacade.Addtran_medexamnotification"));
            }
		}
		
        async Task<long> Itran_medexamnotificationFacadeObjects.SaveList(List<tran_medexamnotificationEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_medexamnotificationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_medexamnotificationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_medexamnotificationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_medexamnotificationDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_medexamnotification"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_medexamnotificationEntity>> Itran_medexamnotificationFacadeObjects.GetAll(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().GetAll(tran_medexamnotification, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_medexamnotificationEntity> Itran_medexamnotificationFacade.GetAlltran_medexamnotification"));
            }
		}
		
		async Task<IList<tran_medexamnotificationEntity>> Itran_medexamnotificationFacadeObjects.GetAllByPages(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().GetAllByPages(tran_medexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_medexamnotificationEntity> Itran_medexamnotificationFacade.GetAllByPagestran_medexamnotification"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_medexamnotificationEntity>  Itran_medexamnotificationFacadeObjects.GetSingle(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().GetSingle(tran_medexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_medexamnotificationEntity Itran_medexamnotificationFacade.GetSingletran_medexamnotification"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_medexamnotificationEntity>> Itran_medexamnotificationFacadeObjects.GAPgListView(tran_medexamnotificationEntity tran_medexamnotification, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_medexamnotificationDataAccess().GAPgListView(tran_medexamnotification,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_medexamnotificationEntity> Itran_medexamnotificationFacade.GAPgListViewtran_medexamnotification"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}