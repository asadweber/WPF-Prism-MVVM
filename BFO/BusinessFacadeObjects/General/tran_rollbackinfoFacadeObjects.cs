
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
    public sealed partial class tran_rollbackinfoFacadeObjects : BaseFacade, Itran_rollbackinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_rollbackinfoFacadeObjects";
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

        public tran_rollbackinfoFacadeObjects()
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

        ~tran_rollbackinfoFacadeObjects()
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
		
		async Task<long> Itran_rollbackinfoFacadeObjects.Delete(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().Delete(tran_rollbackinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_rollbackinfoFacade.Deletetran_rollbackinfo"));
            }
        }
		
		async Task<long> Itran_rollbackinfoFacadeObjects.Update(tran_rollbackinfoEntity tran_rollbackinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().Update(tran_rollbackinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_rollbackinfoFacade.Updatetran_rollbackinfo"));
            }
		}
		
		async Task<long> Itran_rollbackinfoFacadeObjects.Add(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().Add(tran_rollbackinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_rollbackinfoFacade.Addtran_rollbackinfo"));
            }
		}
		
        async Task<long> Itran_rollbackinfoFacadeObjects.SaveList(List<tran_rollbackinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_rollbackinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_rollbackinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_rollbackinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_rollbackinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_rollbackinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoFacadeObjects.GetAll(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().GetAll(tran_rollbackinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_rollbackinfoEntity> Itran_rollbackinfoFacade.GetAlltran_rollbackinfo"));
            }
		}
		
		async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoFacadeObjects.GetAllByPages(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().GetAllByPages(tran_rollbackinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_rollbackinfoEntity> Itran_rollbackinfoFacade.GetAllByPagestran_rollbackinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_rollbackinfoEntity>  Itran_rollbackinfoFacadeObjects.GetSingle(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().GetSingle(tran_rollbackinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_rollbackinfoEntity Itran_rollbackinfoFacade.GetSingletran_rollbackinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoFacadeObjects.GAPgListView(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().GAPgListView(tran_rollbackinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_rollbackinfoEntity> Itran_rollbackinfoFacade.GAPgListViewtran_rollbackinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}