
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
    public sealed partial class tran_volunteermedclearanceFacadeObjects : BaseFacade, Itran_volunteermedclearanceFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_volunteermedclearanceFacadeObjects";
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

        public tran_volunteermedclearanceFacadeObjects()
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

        ~tran_volunteermedclearanceFacadeObjects()
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
		
		async Task<long> Itran_volunteermedclearanceFacadeObjects.Delete(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().Delete(tran_volunteermedclearance, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_volunteermedclearanceFacade.Deletetran_volunteermedclearance"));
            }
        }
		
		async Task<long> Itran_volunteermedclearanceFacadeObjects.Update(tran_volunteermedclearanceEntity tran_volunteermedclearance , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().Update(tran_volunteermedclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_volunteermedclearanceFacade.Updatetran_volunteermedclearance"));
            }
		}
		
		async Task<long> Itran_volunteermedclearanceFacadeObjects.Add(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().Add(tran_volunteermedclearance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_volunteermedclearanceFacade.Addtran_volunteermedclearance"));
            }
		}
		
        async Task<long> Itran_volunteermedclearanceFacadeObjects.SaveList(List<tran_volunteermedclearanceEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_volunteermedclearanceEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_volunteermedclearanceEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_volunteermedclearanceEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_volunteermedclearance"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_volunteermedclearanceEntity>> Itran_volunteermedclearanceFacadeObjects.GetAll(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().GetAll(tran_volunteermedclearance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteermedclearanceEntity> Itran_volunteermedclearanceFacade.GetAlltran_volunteermedclearance"));
            }
		}
		
		async Task<IList<tran_volunteermedclearanceEntity>> Itran_volunteermedclearanceFacadeObjects.GetAllByPages(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().GetAllByPages(tran_volunteermedclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteermedclearanceEntity> Itran_volunteermedclearanceFacade.GetAllByPagestran_volunteermedclearance"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_volunteermedclearanceEntity>  Itran_volunteermedclearanceFacadeObjects.GetSingle(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().GetSingle(tran_volunteermedclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_volunteermedclearanceEntity Itran_volunteermedclearanceFacade.GetSingletran_volunteermedclearance"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_volunteermedclearanceEntity>> Itran_volunteermedclearanceFacadeObjects.GAPgListView(tran_volunteermedclearanceEntity tran_volunteermedclearance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_volunteermedclearanceDataAccess().GAPgListView(tran_volunteermedclearance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_volunteermedclearanceEntity> Itran_volunteermedclearanceFacade.GAPgListViewtran_volunteermedclearance"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}