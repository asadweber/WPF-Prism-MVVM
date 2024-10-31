
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
    public sealed partial class tran_applicantbatchchangeFacadeObjects : BaseFacade, Itran_applicantbatchchangeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_applicantbatchchangeFacadeObjects";
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

        public tran_applicantbatchchangeFacadeObjects()
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

        ~tran_applicantbatchchangeFacadeObjects()
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
		
		async Task<long> Itran_applicantbatchchangeFacadeObjects.Delete(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().Delete(tran_applicantbatchchange, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantbatchchangeFacade.Deletetran_applicantbatchchange"));
            }
        }
		
		async Task<long> Itran_applicantbatchchangeFacadeObjects.Update(tran_applicantbatchchangeEntity tran_applicantbatchchange , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().Update(tran_applicantbatchchange,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_applicantbatchchangeFacade.Updatetran_applicantbatchchange"));
            }
		}
		
		async Task<long> Itran_applicantbatchchangeFacadeObjects.Add(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().Add(tran_applicantbatchchange, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantbatchchangeFacade.Addtran_applicantbatchchange"));
            }
		}
		
        async Task<long> Itran_applicantbatchchangeFacadeObjects.SaveList(List<tran_applicantbatchchangeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_applicantbatchchangeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_applicantbatchchangeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_applicantbatchchangeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_applicantbatchchange"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_applicantbatchchangeEntity>> Itran_applicantbatchchangeFacadeObjects.GetAll(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().GetAll(tran_applicantbatchchange, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantbatchchangeEntity> Itran_applicantbatchchangeFacade.GetAlltran_applicantbatchchange"));
            }
		}
		
		async Task<IList<tran_applicantbatchchangeEntity>> Itran_applicantbatchchangeFacadeObjects.GetAllByPages(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().GetAllByPages(tran_applicantbatchchange,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantbatchchangeEntity> Itran_applicantbatchchangeFacade.GetAllByPagestran_applicantbatchchange"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_applicantbatchchangeEntity>  Itran_applicantbatchchangeFacadeObjects.GetSingle(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().GetSingle(tran_applicantbatchchange,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_applicantbatchchangeEntity Itran_applicantbatchchangeFacade.GetSingletran_applicantbatchchange"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_applicantbatchchangeEntity>> Itran_applicantbatchchangeFacadeObjects.GAPgListView(tran_applicantbatchchangeEntity tran_applicantbatchchange, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantbatchchangeDataAccess().GAPgListView(tran_applicantbatchchange,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantbatchchangeEntity> Itran_applicantbatchchangeFacade.GAPgListViewtran_applicantbatchchange"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}