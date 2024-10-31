
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
    public sealed partial class tran_notificationbatchdetFacadeObjects : BaseFacade, Itran_notificationbatchdetFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_notificationbatchdetFacadeObjects";
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

        public tran_notificationbatchdetFacadeObjects()
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

        ~tran_notificationbatchdetFacadeObjects()
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
		
		async Task<long> Itran_notificationbatchdetFacadeObjects.Delete(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().Delete(tran_notificationbatchdet, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchdetFacade.Deletetran_notificationbatchdet"));
            }
        }
		
		async Task<long> Itran_notificationbatchdetFacadeObjects.Update(tran_notificationbatchdetEntity tran_notificationbatchdet , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().Update(tran_notificationbatchdet,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchdetFacade.Updatetran_notificationbatchdet"));
            }
		}
		
		async Task<long> Itran_notificationbatchdetFacadeObjects.Add(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().Add(tran_notificationbatchdet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_notificationbatchdetFacade.Addtran_notificationbatchdet"));
            }
		}
		
        async Task<long> Itran_notificationbatchdetFacadeObjects.SaveList(List<tran_notificationbatchdetEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_notificationbatchdetEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_notificationbatchdetEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_notificationbatchdetEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_notificationbatchdet"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetFacadeObjects.GetAll(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GetAll(tran_notificationbatchdet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchdetEntity> Itran_notificationbatchdetFacade.GetAlltran_notificationbatchdet"));
            }
		}
		
		async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetFacadeObjects.GetAllByPages(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GetAllByPages(tran_notificationbatchdet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchdetEntity> Itran_notificationbatchdetFacade.GetAllByPagestran_notificationbatchdet"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Itran_notificationbatchdetFacadeObjects.SaveMasterDettran_notificationbatchdet(tran_notificationbatchdetEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().SaveMasterDettran_notificationbatchdet(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatchdet"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_notificationbatchdetEntity>  Itran_notificationbatchdetFacadeObjects.GetSingle(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GetSingle(tran_notificationbatchdet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_notificationbatchdetEntity Itran_notificationbatchdetFacade.GetSingletran_notificationbatchdet"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_notificationbatchdetEntity>> Itran_notificationbatchdetFacadeObjects.GAPgListView(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GAPgListView(tran_notificationbatchdet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchdetEntity> Itran_notificationbatchdetFacade.GAPgListViewtran_notificationbatchdet"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Itran_notificationbatchdetFacadeObjects.GetDataForDropDown(tran_notificationbatchdetEntity tran_notificationbatchdet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_notificationbatchdetDataAccess().GetDataForDropDown(tran_notificationbatchdet,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<tran_notificationbatchdetEntity> Itran_notificationbatchdetFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}