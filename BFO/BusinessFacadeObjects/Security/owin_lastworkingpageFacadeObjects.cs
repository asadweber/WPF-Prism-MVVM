


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
    public sealed partial class owin_lastworkingpageFacadeObjects : BaseFacade, Iowin_lastworkingpageFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_lastworkingpageFacadeObjects";
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

        public owin_lastworkingpageFacadeObjects()
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

        ~owin_lastworkingpageFacadeObjects()
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
		
		async Task<long> Iowin_lastworkingpageFacadeObjects.Delete(owin_lastworkingpageEntity owin_lastworkingpage, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().Delete(owin_lastworkingpage, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_lastworkingpageFacade.Deleteowin_lastworkingpage"));
            }
        }
		
		async Task<long> Iowin_lastworkingpageFacadeObjects.Update(owin_lastworkingpageEntity owin_lastworkingpage , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().Update(owin_lastworkingpage,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_lastworkingpageFacade.Updateowin_lastworkingpage"));
            }
		}
		
		async Task<long> Iowin_lastworkingpageFacadeObjects.Add(owin_lastworkingpageEntity owin_lastworkingpage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().Add(owin_lastworkingpage, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_lastworkingpageFacade.Addowin_lastworkingpage"));
            }
		}
		
        async Task<long> Iowin_lastworkingpageFacadeObjects.SaveList(List<owin_lastworkingpageEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_lastworkingpageEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_lastworkingpageEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_lastworkingpageEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_lastworkingpageDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_lastworkingpage"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_lastworkingpageEntity>> Iowin_lastworkingpageFacadeObjects.GetAll(owin_lastworkingpageEntity owin_lastworkingpage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().GetAll(owin_lastworkingpage, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_lastworkingpageEntity> Iowin_lastworkingpageFacade.GetAllowin_lastworkingpage"));
            }
		}
		
		async Task<IList<owin_lastworkingpageEntity>> Iowin_lastworkingpageFacadeObjects.GetAllByPages(owin_lastworkingpageEntity owin_lastworkingpage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().GetAllByPages(owin_lastworkingpage,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_lastworkingpageEntity> Iowin_lastworkingpageFacade.GetAllByPagesowin_lastworkingpage"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_lastworkingpageEntity>  Iowin_lastworkingpageFacadeObjects.GetSingle(owin_lastworkingpageEntity owin_lastworkingpage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().GetSingle(owin_lastworkingpage,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_lastworkingpageEntity Iowin_lastworkingpageFacade.GetSingleowin_lastworkingpage"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_lastworkingpageEntity>> Iowin_lastworkingpageFacadeObjects.GAPgListView(owin_lastworkingpageEntity owin_lastworkingpage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_lastworkingpageDataAccess().GAPgListView(owin_lastworkingpage,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_lastworkingpageEntity> Iowin_lastworkingpageFacade.GAPgListViewowin_lastworkingpage"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}