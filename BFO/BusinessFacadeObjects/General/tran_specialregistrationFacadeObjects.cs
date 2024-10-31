
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
    public sealed partial class tran_specialregistrationFacadeObjects : BaseFacade, Itran_specialregistrationFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_specialregistrationFacadeObjects";
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

        public tran_specialregistrationFacadeObjects()
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

        ~tran_specialregistrationFacadeObjects()
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
		
		async Task<long> Itran_specialregistrationFacadeObjects.Delete(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().Delete(tran_specialregistration, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_specialregistrationFacade.Deletetran_specialregistration"));
            }
        }
		
		async Task<long> Itran_specialregistrationFacadeObjects.Update(tran_specialregistrationEntity tran_specialregistration , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().Update(tran_specialregistration,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_specialregistrationFacade.Updatetran_specialregistration"));
            }
		}
		
		async Task<long> Itran_specialregistrationFacadeObjects.Add(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().Add(tran_specialregistration, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_specialregistrationFacade.Addtran_specialregistration"));
            }
		}
		
        async Task<long> Itran_specialregistrationFacadeObjects.SaveList(List<tran_specialregistrationEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_specialregistrationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_specialregistrationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_specialregistrationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_specialregistrationDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_specialregistration"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationFacadeObjects.GetAll(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().GetAll(tran_specialregistration, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_specialregistrationEntity> Itran_specialregistrationFacade.GetAlltran_specialregistration"));
            }
		}
		
		async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationFacadeObjects.GetAllByPages(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().GetAllByPages(tran_specialregistration,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_specialregistrationEntity> Itran_specialregistrationFacade.GetAllByPagestran_specialregistration"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_specialregistrationEntity>  Itran_specialregistrationFacadeObjects.GetSingle(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().GetSingle(tran_specialregistration,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_specialregistrationEntity Itran_specialregistrationFacade.GetSingletran_specialregistration"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationFacadeObjects.GAPgListView(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().GAPgListView(tran_specialregistration,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_specialregistrationEntity> Itran_specialregistrationFacade.GAPgListViewtran_specialregistration"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}