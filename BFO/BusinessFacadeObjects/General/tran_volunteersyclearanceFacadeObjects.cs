
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
    public sealed partial class tran_volunteersyclearanceFacadeObjects : BaseFacade, Itran_volunteersyclearanceFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_volunteersyclearanceFacadeObjects";
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

        public tran_volunteersyclearanceFacadeObjects()
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

        ~tran_volunteersyclearanceFacadeObjects()
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
		
		async Task<long> Itran_volunteersyclearanceFacadeObjects.Delete(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().Delete(tran_volunteersyclearance, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_volunteersyclearanceFacade.Deletetran_volunteersyclearance"));
            }
        }
		
		async Task<long> Itran_volunteersyclearanceFacadeObjects.Update(tran_volunteersyclearanceEntity tran_volunteersyclearance , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().Update(tran_volunteersyclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_volunteersyclearanceFacade.Updatetran_volunteersyclearance"));
            }
		}
		
		async Task<long> Itran_volunteersyclearanceFacadeObjects.Add(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().Add(tran_volunteersyclearance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_volunteersyclearanceFacade.Addtran_volunteersyclearance"));
            }
		}
		
        async Task<long> Itran_volunteersyclearanceFacadeObjects.SaveList(List<tran_volunteersyclearanceEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_volunteersyclearanceEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_volunteersyclearanceEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_volunteersyclearanceEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_volunteersyclearance"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_volunteersyclearanceEntity>> Itran_volunteersyclearanceFacadeObjects.GetAll(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().GetAll(tran_volunteersyclearance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteersyclearanceEntity> Itran_volunteersyclearanceFacade.GetAlltran_volunteersyclearance"));
            }
		}
		
		async Task<IList<tran_volunteersyclearanceEntity>> Itran_volunteersyclearanceFacadeObjects.GetAllByPages(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().GetAllByPages(tran_volunteersyclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteersyclearanceEntity> Itran_volunteersyclearanceFacade.GetAllByPagestran_volunteersyclearance"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_volunteersyclearanceEntity>  Itran_volunteersyclearanceFacadeObjects.GetSingle(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().GetSingle(tran_volunteersyclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_volunteersyclearanceEntity Itran_volunteersyclearanceFacade.GetSingletran_volunteersyclearance"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_volunteersyclearanceEntity>> Itran_volunteersyclearanceFacadeObjects.GAPgListView(tran_volunteersyclearanceEntity tran_volunteersyclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteersyclearanceDataAccess().GAPgListView(tran_volunteersyclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteersyclearanceEntity> Itran_volunteersyclearanceFacade.GAPgListViewtran_volunteersyclearance"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}