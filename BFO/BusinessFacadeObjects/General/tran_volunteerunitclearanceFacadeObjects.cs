
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
    public sealed partial class tran_volunteerunitclearanceFacadeObjects : BaseFacade, Itran_volunteerunitclearanceFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_volunteerunitclearanceFacadeObjects";
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

        public tran_volunteerunitclearanceFacadeObjects()
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

        ~tran_volunteerunitclearanceFacadeObjects()
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
		
		async Task<long> Itran_volunteerunitclearanceFacadeObjects.Delete(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().Delete(tran_volunteerunitclearance, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_volunteerunitclearanceFacade.Deletetran_volunteerunitclearance"));
            }
        }
		
		async Task<long> Itran_volunteerunitclearanceFacadeObjects.Update(tran_volunteerunitclearanceEntity tran_volunteerunitclearance , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().Update(tran_volunteerunitclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_volunteerunitclearanceFacade.Updatetran_volunteerunitclearance"));
            }
		}
		
		async Task<long> Itran_volunteerunitclearanceFacadeObjects.Add(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().Add(tran_volunteerunitclearance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_volunteerunitclearanceFacade.Addtran_volunteerunitclearance"));
            }
		}
		
        async Task<long> Itran_volunteerunitclearanceFacadeObjects.SaveList(List<tran_volunteerunitclearanceEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_volunteerunitclearanceEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_volunteerunitclearanceEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_volunteerunitclearanceEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_volunteerunitclearance"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_volunteerunitclearanceEntity>> Itran_volunteerunitclearanceFacadeObjects.GetAll(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().GetAll(tran_volunteerunitclearance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteerunitclearanceEntity> Itran_volunteerunitclearanceFacade.GetAlltran_volunteerunitclearance"));
            }
		}
		
		async Task<IList<tran_volunteerunitclearanceEntity>> Itran_volunteerunitclearanceFacadeObjects.GetAllByPages(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().GetAllByPages(tran_volunteerunitclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteerunitclearanceEntity> Itran_volunteerunitclearanceFacade.GetAllByPagestran_volunteerunitclearance"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_volunteerunitclearanceEntity>  Itran_volunteerunitclearanceFacadeObjects.GetSingle(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().GetSingle(tran_volunteerunitclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_volunteerunitclearanceEntity Itran_volunteerunitclearanceFacade.GetSingletran_volunteerunitclearance"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_volunteerunitclearanceEntity>> Itran_volunteerunitclearanceFacadeObjects.GAPgListView(tran_volunteerunitclearanceEntity tran_volunteerunitclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteerunitclearanceDataAccess().GAPgListView(tran_volunteerunitclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteerunitclearanceEntity> Itran_volunteerunitclearanceFacade.GAPgListViewtran_volunteerunitclearance"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}