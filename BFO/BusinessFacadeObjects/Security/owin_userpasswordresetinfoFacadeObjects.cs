


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
    public sealed partial class owin_userpasswordresetinfoFacadeObjects : BaseFacade, Iowin_userpasswordresetinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_userpasswordresetinfoFacadeObjects";
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

        public owin_userpasswordresetinfoFacadeObjects()
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

        ~owin_userpasswordresetinfoFacadeObjects()
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
		
		async Task<long> Iowin_userpasswordresetinfoFacadeObjects.Delete(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().Delete(owin_userpasswordresetinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userpasswordresetinfoFacade.Deleteowin_userpasswordresetinfo"));
            }
        }
		
		async Task<long> Iowin_userpasswordresetinfoFacadeObjects.Update(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().Update(owin_userpasswordresetinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_userpasswordresetinfoFacade.Updateowin_userpasswordresetinfo"));
            }
		}
		
		async Task<long> Iowin_userpasswordresetinfoFacadeObjects.Add(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().Add(owin_userpasswordresetinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_userpasswordresetinfoFacade.Addowin_userpasswordresetinfo"));
            }
		}
		
        async Task<long> Iowin_userpasswordresetinfoFacadeObjects.SaveList(List<owin_userpasswordresetinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_userpasswordresetinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_userpasswordresetinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_userpasswordresetinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_userpasswordresetinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_userpasswordresetinfoEntity>> Iowin_userpasswordresetinfoFacadeObjects.GetAll(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().GetAll(owin_userpasswordresetinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userpasswordresetinfoEntity> Iowin_userpasswordresetinfoFacade.GetAllowin_userpasswordresetinfo"));
            }
		}
		
		async Task<IList<owin_userpasswordresetinfoEntity>> Iowin_userpasswordresetinfoFacadeObjects.GetAllByPages(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().GetAllByPages(owin_userpasswordresetinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userpasswordresetinfoEntity> Iowin_userpasswordresetinfoFacade.GetAllByPagesowin_userpasswordresetinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_userpasswordresetinfoEntity>  Iowin_userpasswordresetinfoFacadeObjects.GetSingle(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().GetSingle(owin_userpasswordresetinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_userpasswordresetinfoEntity Iowin_userpasswordresetinfoFacade.GetSingleowin_userpasswordresetinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_userpasswordresetinfoEntity>> Iowin_userpasswordresetinfoFacadeObjects.GAPgListView(owin_userpasswordresetinfoEntity owin_userpasswordresetinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_userpasswordresetinfoDataAccess().GAPgListView(owin_userpasswordresetinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_userpasswordresetinfoEntity> Iowin_userpasswordresetinfoFacade.GAPgListViewowin_userpasswordresetinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}