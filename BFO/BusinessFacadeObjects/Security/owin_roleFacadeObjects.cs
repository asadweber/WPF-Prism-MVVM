


using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security
{
    public sealed partial class owin_roleFacadeObjects : BaseFacade, Iowin_roleFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_roleFacadeObjects";
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

        public owin_roleFacadeObjects()
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

        ~owin_roleFacadeObjects()
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
		
		async Task<long> Iowin_roleFacadeObjects.Delete(owin_roleEntity owin_role, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_roleDataAccess().Delete(owin_role, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_roleFacade.Deleteowin_role"));
            }
        }
		
		async Task<long> Iowin_roleFacadeObjects.Update(owin_roleEntity owin_role , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().Update(owin_role,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_roleFacade.Updateowin_role"));
            }
		}
		
		async Task<long> Iowin_roleFacadeObjects.Add(owin_roleEntity owin_role, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().Add(owin_role, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_roleFacade.Addowin_role"));
            }
		}
		
        async Task<long> Iowin_roleFacadeObjects.SaveList(List<owin_roleEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_roleEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_roleEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_roleEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_roleDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_role"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_roleEntity>> Iowin_roleFacadeObjects.GetAll(owin_roleEntity owin_role, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().GetAll(owin_role, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> Iowin_roleFacade.GetAllowin_role"));
            }
		}
		
		async Task<IList<owin_roleEntity>> Iowin_roleFacadeObjects.GetAllByPages(owin_roleEntity owin_role, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().GetAllByPages(owin_role,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> Iowin_roleFacade.GetAllByPagesowin_role"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_roleEntity>  Iowin_roleFacadeObjects.GetSingle(owin_roleEntity owin_role, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().GetSingle(owin_role,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_roleEntity Iowin_roleFacade.GetSingleowin_role"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_roleEntity>> Iowin_roleFacadeObjects.GAPgListView(owin_roleEntity owin_role, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_roleDataAccess().GAPgListView(owin_role,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> Iowin_roleFacade.GAPgListViewowin_role"));
            }
		}
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Iowin_roleFacadeObjects.GetDataForDropDown(owin_roleEntity owin_role, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createowin_roleDataAccess().GetDataForDropDown(owin_role, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_roleEntity> Iowin_roleFacade.GetDataForDropDown"));
            }
        }
        #endregion
    }
}