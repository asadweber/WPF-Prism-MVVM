
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
    public sealed partial class tran_trainingjoinFacadeObjects : BaseFacade, Itran_trainingjoinFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_trainingjoinFacadeObjects";
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

        public tran_trainingjoinFacadeObjects()
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

        ~tran_trainingjoinFacadeObjects()
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
		
		async Task<long> Itran_trainingjoinFacadeObjects.Delete(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().Delete(tran_trainingjoin, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_trainingjoinFacade.Deletetran_trainingjoin"));
            }
        }
		
		async Task<long> Itran_trainingjoinFacadeObjects.Update(tran_trainingjoinEntity tran_trainingjoin , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().Update(tran_trainingjoin,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_trainingjoinFacade.Updatetran_trainingjoin"));
            }
		}
		
		async Task<long> Itran_trainingjoinFacadeObjects.Add(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().Add(tran_trainingjoin, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_trainingjoinFacade.Addtran_trainingjoin"));
            }
		}
		
        async Task<long> Itran_trainingjoinFacadeObjects.SaveList(List<tran_trainingjoinEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_trainingjoinEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_trainingjoinEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_trainingjoinEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_trainingjoinDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_trainingjoin"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_trainingjoinEntity>> Itran_trainingjoinFacadeObjects.GetAll(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().GetAll(tran_trainingjoin, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_trainingjoinEntity> Itran_trainingjoinFacade.GetAlltran_trainingjoin"));
            }
		}
		
		async Task<IList<tran_trainingjoinEntity>> Itran_trainingjoinFacadeObjects.GetAllByPages(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().GetAllByPages(tran_trainingjoin,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_trainingjoinEntity> Itran_trainingjoinFacade.GetAllByPagestran_trainingjoin"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_trainingjoinEntity>  Itran_trainingjoinFacadeObjects.GetSingle(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().GetSingle(tran_trainingjoin,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_trainingjoinEntity Itran_trainingjoinFacade.GetSingletran_trainingjoin"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_trainingjoinEntity>> Itran_trainingjoinFacadeObjects.GAPgListView(tran_trainingjoinEntity tran_trainingjoin, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_trainingjoinDataAccess().GAPgListView(tran_trainingjoin,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_trainingjoinEntity> Itran_trainingjoinFacade.GAPgListViewtran_trainingjoin"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}