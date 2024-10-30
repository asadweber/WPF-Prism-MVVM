


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
    public sealed partial class owin_userroleFacadeObjects : BaseFacade, Iowin_userroleFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userroleFacadeObjects";
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

        public owin_userroleFacadeObjects()
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

        ~owin_userroleFacadeObjects()
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
		
		async Task<long> Iowin_userroleFacadeObjects.Delete(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userroleDataAccess().Delete(owin_userrole, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroleFacade.Deleteowin_userrole"));
            }
        }
		
		async Task<long> Iowin_userroleFacadeObjects.Update(owin_userroleEntity owin_userrole , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userroleDataAccess().Update(owin_userrole,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userroleFacade.Updateowin_userrole"));
            }
		}
		
		async Task<long> Iowin_userroleFacadeObjects.Add(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userroleDataAccess().Add(owin_userrole, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userroleFacade.Addowin_userrole"));
            }
		}
		
        async Task<long> Iowin_userroleFacadeObjects.SaveList(List<owin_userroleEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userroleEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userroleEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userroleEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userroleDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userrole"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userroleEntity>> Iowin_userroleFacadeObjects.GetAll(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userroleDataAccess().GetAll(owin_userrole, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroleEntity> Iowin_userroleFacade.GetAllowin_userrole"));
            }
		}
		
		async Task<IList<owin_userroleEntity>> Iowin_userroleFacadeObjects.GetAllByPages(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userroleDataAccess().GetAllByPages(owin_userrole,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroleEntity> Iowin_userroleFacade.GetAllByPagesowin_userrole"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userroleEntity>  Iowin_userroleFacadeObjects.GetSingle(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userroleDataAccess().GetSingle(owin_userrole,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userroleEntity Iowin_userroleFacade.GetSingleowin_userrole"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userroleEntity>> Iowin_userroleFacadeObjects.GAPgListView(owin_userroleEntity owin_userrole, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userroleDataAccess().GAPgListView(owin_userrole,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userroleEntity> Iowin_userroleFacade.GAPgListViewowin_userrole"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}