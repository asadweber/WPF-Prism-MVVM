
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
    public sealed partial class tran_notificationbatchFacadeObjects : BaseFacade, Itran_notificationbatchFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_notificationbatchFacadeObjects";
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

        public tran_notificationbatchFacadeObjects()
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

        ~tran_notificationbatchFacadeObjects()
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
		
		async Task<long> Itran_notificationbatchFacadeObjects.Delete(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().Delete(tran_notificationbatch, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchFacade.Deletetran_notificationbatch"));
            }
        }
		
		async Task<long> Itran_notificationbatchFacadeObjects.Update(tran_notificationbatchEntity tran_notificationbatch , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().Update(tran_notificationbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchFacade.Updatetran_notificationbatch"));
            }
		}
		
		async Task<long> Itran_notificationbatchFacadeObjects.Add(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().Add(tran_notificationbatch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchFacade.Addtran_notificationbatch"));
            }
		}
		
        async Task<long> Itran_notificationbatchFacadeObjects.SaveList(List<tran_notificationbatchEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_notificationbatchEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_notificationbatchEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_notificationbatchEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_notificationbatchDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_notificationbatch"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchFacadeObjects.GetAll(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().GetAll(tran_notificationbatch, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchEntity> Itran_notificationbatchFacade.GetAlltran_notificationbatch"));
            }
		}
		
		async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchFacadeObjects.GetAllByPages(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().GetAllByPages(tran_notificationbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchEntity> Itran_notificationbatchFacade.GetAllByPagestran_notificationbatch"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Itran_notificationbatchFacadeObjects.SaveMasterDettran_notificationbatchdet(tran_notificationbatchEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_notificationbatchdetEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_notificationbatchdetEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_notificationbatchdetEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createtran_notificationbatchDataAccess().SaveMasterDettran_notificationbatchdet(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatchdet"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_notificationbatchEntity>  Itran_notificationbatchFacadeObjects.GetSingle(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().GetSingle(tran_notificationbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_notificationbatchEntity Itran_notificationbatchFacade.GetSingletran_notificationbatch"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_notificationbatchEntity>> Itran_notificationbatchFacadeObjects.GAPgListView(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().GAPgListView(tran_notificationbatch,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchEntity> Itran_notificationbatchFacade.GAPgListViewtran_notificationbatch"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Itran_notificationbatchFacadeObjects.GetDataForDropDown(tran_notificationbatchEntity tran_notificationbatch, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchDataAccess().GetDataForDropDown(tran_notificationbatch,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchEntity> Itran_notificationbatchFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}