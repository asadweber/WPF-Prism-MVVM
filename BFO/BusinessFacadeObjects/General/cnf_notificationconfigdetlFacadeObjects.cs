
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
    public sealed partial class cnf_notificationconfigdetlFacadeObjects : BaseFacade, Icnf_notificationconfigdetlFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_notificationconfigdetlFacadeObjects";
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

        public cnf_notificationconfigdetlFacadeObjects()
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

        ~cnf_notificationconfigdetlFacadeObjects()
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
		
		async Task<long> Icnf_notificationconfigdetlFacadeObjects.Delete(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().Delete(cnf_notificationconfigdetl, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigdetlFacade.Deletecnf_notificationconfigdetl"));
            }
        }
		
		async Task<long> Icnf_notificationconfigdetlFacadeObjects.Update(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().Update(cnf_notificationconfigdetl,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigdetlFacade.Updatecnf_notificationconfigdetl"));
            }
		}
		
		async Task<long> Icnf_notificationconfigdetlFacadeObjects.Add(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().Add(cnf_notificationconfigdetl, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigdetlFacade.Addcnf_notificationconfigdetl"));
            }
		}
		
        async Task<long> Icnf_notificationconfigdetlFacadeObjects.SaveList(List<cnf_notificationconfigdetlEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_notificationconfigdetlEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_notificationconfigdetlEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_notificationconfigdetlEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_notificationconfigdetl"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlFacadeObjects.GetAll(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GetAll(cnf_notificationconfigdetl, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlFacade.GetAllcnf_notificationconfigdetl"));
            }
		}
		
		async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlFacadeObjects.GetAllByPages(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GetAllByPages(cnf_notificationconfigdetl,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlFacade.GetAllByPagescnf_notificationconfigdetl"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_notificationconfigdetlEntity>  Icnf_notificationconfigdetlFacadeObjects.GetSingle(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GetSingle(cnf_notificationconfigdetl,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_notificationconfigdetlEntity Icnf_notificationconfigdetlFacade.GetSinglecnf_notificationconfigdetl"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_notificationconfigdetlEntity>> Icnf_notificationconfigdetlFacadeObjects.GAPgListView(cnf_notificationconfigdetlEntity cnf_notificationconfigdetl, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigdetlDataAccess().GAPgListView(cnf_notificationconfigdetl,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigdetlEntity> Icnf_notificationconfigdetlFacade.GAPgListViewcnf_notificationconfigdetl"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}