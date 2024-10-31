
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
    public sealed partial class cnf_notificationconfigFacadeObjects : BaseFacade, Icnf_notificationconfigFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_notificationconfigFacadeObjects";
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

        public cnf_notificationconfigFacadeObjects()
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

        ~cnf_notificationconfigFacadeObjects()
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
		
		async Task<long> Icnf_notificationconfigFacadeObjects.Delete(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().Delete(cnf_notificationconfig, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigFacade.Deletecnf_notificationconfig"));
            }
        }
		
		async Task<long> Icnf_notificationconfigFacadeObjects.Update(cnf_notificationconfigEntity cnf_notificationconfig , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().Update(cnf_notificationconfig,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigFacade.Updatecnf_notificationconfig"));
            }
		}
		
		async Task<long> Icnf_notificationconfigFacadeObjects.Add(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().Add(cnf_notificationconfig, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationconfigFacade.Addcnf_notificationconfig"));
            }
		}
		
        async Task<long> Icnf_notificationconfigFacadeObjects.SaveList(List<cnf_notificationconfigEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_notificationconfigEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_notificationconfigEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_notificationconfigEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_notificationconfigDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_notificationconfig"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigFacadeObjects.GetAll(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GetAll(cnf_notificationconfig, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GetAllcnf_notificationconfig"));
            }
		}
		
		async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigFacadeObjects.GetAllByPages(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GetAllByPages(cnf_notificationconfig,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GetAllByPagescnf_notificationconfig"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Icnf_notificationconfigFacadeObjects.SaveMasterDetcnf_notificationconfigdetl(cnf_notificationconfigEntity Master, List<cnf_notificationconfigdetlEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_notificationconfigdetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_notificationconfigdetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_notificationconfigdetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createcnf_notificationconfigDataAccess().SaveMasterDetcnf_notificationconfigdetl(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_notificationconfigdetl"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_notificationconfigEntity>  Icnf_notificationconfigFacadeObjects.GetSingle(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GetSingle(cnf_notificationconfig,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_notificationconfigEntity Icnf_notificationconfigFacade.GetSinglecnf_notificationconfig"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_notificationconfigEntity>> Icnf_notificationconfigFacadeObjects.GAPgListView(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GAPgListView(cnf_notificationconfig,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GAPgListViewcnf_notificationconfig"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_notificationconfigFacadeObjects.GetDataForDropDown(cnf_notificationconfigEntity cnf_notificationconfig, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationconfigDataAccess().GetDataForDropDown(cnf_notificationconfig,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationconfigEntity> Icnf_notificationconfigFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}