


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
    public sealed partial class owin_userclaimsFacadeObjects : BaseFacade, Iowin_userclaimsFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userclaimsFacadeObjects";
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

        public owin_userclaimsFacadeObjects()
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

        ~owin_userclaimsFacadeObjects()
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
		
		async Task<long> Iowin_userclaimsFacadeObjects.Delete(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userclaimsDataAccess().Delete(owin_userclaims, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userclaimsFacade.Deleteowin_userclaims"));
            }
        }
		
		async Task<long> Iowin_userclaimsFacadeObjects.Update(owin_userclaimsEntity owin_userclaims , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userclaimsDataAccess().Update(owin_userclaims,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userclaimsFacade.Updateowin_userclaims"));
            }
		}
		
		async Task<long> Iowin_userclaimsFacadeObjects.Add(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userclaimsDataAccess().Add(owin_userclaims, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userclaimsFacade.Addowin_userclaims"));
            }
		}
		
        async Task<long> Iowin_userclaimsFacadeObjects.SaveList(List<owin_userclaimsEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userclaimsEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userclaimsEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userclaimsEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userclaimsDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userclaims"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userclaimsEntity>> Iowin_userclaimsFacadeObjects.GetAll(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userclaimsDataAccess().GetAll(owin_userclaims, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userclaimsEntity> Iowin_userclaimsFacade.GetAllowin_userclaims"));
            }
		}
		
		async Task<IList<owin_userclaimsEntity>> Iowin_userclaimsFacadeObjects.GetAllByPages(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userclaimsDataAccess().GetAllByPages(owin_userclaims,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userclaimsEntity> Iowin_userclaimsFacade.GetAllByPagesowin_userclaims"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userclaimsEntity>  Iowin_userclaimsFacadeObjects.GetSingle(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userclaimsDataAccess().GetSingle(owin_userclaims,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userclaimsEntity Iowin_userclaimsFacade.GetSingleowin_userclaims"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userclaimsEntity>> Iowin_userclaimsFacadeObjects.GAPgListView(owin_userclaimsEntity owin_userclaims, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userclaimsDataAccess().GAPgListView(owin_userclaims,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userclaimsEntity> Iowin_userclaimsFacade.GAPgListViewowin_userclaims"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}