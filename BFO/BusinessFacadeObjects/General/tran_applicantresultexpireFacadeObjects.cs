
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
    public sealed partial class tran_applicantresultexpireFacadeObjects : BaseFacade, Itran_applicantresultexpireFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_applicantresultexpireFacadeObjects";
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

        public tran_applicantresultexpireFacadeObjects()
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

        ~tran_applicantresultexpireFacadeObjects()
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
		
		async Task<long> Itran_applicantresultexpireFacadeObjects.Delete(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().Delete(tran_applicantresultexpire, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantresultexpireFacade.Deletetran_applicantresultexpire"));
            }
        }
		
		async Task<long> Itran_applicantresultexpireFacadeObjects.Update(tran_applicantresultexpireEntity tran_applicantresultexpire , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().Update(tran_applicantresultexpire,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_applicantresultexpireFacade.Updatetran_applicantresultexpire"));
            }
		}
		
		async Task<long> Itran_applicantresultexpireFacadeObjects.Add(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().Add(tran_applicantresultexpire, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantresultexpireFacade.Addtran_applicantresultexpire"));
            }
		}
		
        async Task<long> Itran_applicantresultexpireFacadeObjects.SaveList(List<tran_applicantresultexpireEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_applicantresultexpireEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_applicantresultexpireEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_applicantresultexpireEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_applicantresultexpire"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_applicantresultexpireEntity>> Itran_applicantresultexpireFacadeObjects.GetAll(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().GetAll(tran_applicantresultexpire, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantresultexpireEntity> Itran_applicantresultexpireFacade.GetAlltran_applicantresultexpire"));
            }
		}
		
		async Task<IList<tran_applicantresultexpireEntity>> Itran_applicantresultexpireFacadeObjects.GetAllByPages(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().GetAllByPages(tran_applicantresultexpire,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantresultexpireEntity> Itran_applicantresultexpireFacade.GetAllByPagestran_applicantresultexpire"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_applicantresultexpireEntity>  Itran_applicantresultexpireFacadeObjects.GetSingle(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().GetSingle(tran_applicantresultexpire,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_applicantresultexpireEntity Itran_applicantresultexpireFacade.GetSingletran_applicantresultexpire"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_applicantresultexpireEntity>> Itran_applicantresultexpireFacadeObjects.GAPgListView(tran_applicantresultexpireEntity tran_applicantresultexpire, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantresultexpireDataAccess().GAPgListView(tran_applicantresultexpire,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantresultexpireEntity> Itran_applicantresultexpireFacade.GAPgListViewtran_applicantresultexpire"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}