


using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security
{
    public sealed partial class owin_userlogintrailFacadeObjects : BaseFacade, Iowin_userlogintrailFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userlogintrailFacadeObjects";
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

        public owin_userlogintrailFacadeObjects()
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

        ~owin_userlogintrailFacadeObjects()
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
		
		async Task<long> Iowin_userlogintrailFacadeObjects.Delete(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().Delete(owin_userlogintrail, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userlogintrailFacade.Deleteowin_userlogintrail"));
            }
        }
		
		async Task<long> Iowin_userlogintrailFacadeObjects.Update(owin_userlogintrailEntity owin_userlogintrail , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().Update(owin_userlogintrail,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userlogintrailFacade.Updateowin_userlogintrail"));
            }
		}
		
		async Task<long> Iowin_userlogintrailFacadeObjects.Add(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().Add(owin_userlogintrail, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userlogintrailFacade.Addowin_userlogintrail"));
            }
		}
		
        async Task<long> Iowin_userlogintrailFacadeObjects.SaveList(List<owin_userlogintrailEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userlogintrailEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userlogintrailEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userlogintrailEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userlogintrailDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userlogintrail"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userlogintrailEntity>> Iowin_userlogintrailFacadeObjects.GetAll(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().GetAll(owin_userlogintrail, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userlogintrailEntity> Iowin_userlogintrailFacade.GetAllowin_userlogintrail"));
            }
		}
		
		async Task<IList<owin_userlogintrailEntity>> Iowin_userlogintrailFacadeObjects.GetAllByPages(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().GetAllByPages(owin_userlogintrail,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userlogintrailEntity> Iowin_userlogintrailFacade.GetAllByPagesowin_userlogintrail"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userlogintrailEntity>  Iowin_userlogintrailFacadeObjects.GetSingle(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().GetSingle(owin_userlogintrail,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userlogintrailEntity Iowin_userlogintrailFacade.GetSingleowin_userlogintrail"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userlogintrailEntity>> Iowin_userlogintrailFacadeObjects.GAPgListView(owin_userlogintrailEntity owin_userlogintrail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userlogintrailDataAccess().GAPgListView(owin_userlogintrail,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userlogintrailEntity> Iowin_userlogintrailFacade.GAPgListViewowin_userlogintrail"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}