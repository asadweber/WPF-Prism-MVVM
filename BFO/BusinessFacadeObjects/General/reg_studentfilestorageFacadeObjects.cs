
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
    public sealed partial class reg_studentfilestorageFacadeObjects : BaseFacade, Ireg_studentfilestorageFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_studentfilestorageFacadeObjects";
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

        public reg_studentfilestorageFacadeObjects()
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

        ~reg_studentfilestorageFacadeObjects()
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
		
		async Task<long> Ireg_studentfilestorageFacadeObjects.Delete(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().Delete(reg_studentfilestorage, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_studentfilestorageFacade.Deletereg_studentfilestorage"));
            }
        }
		
		async Task<long> Ireg_studentfilestorageFacadeObjects.Update(reg_studentfilestorageEntity reg_studentfilestorage , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().Update(reg_studentfilestorage,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_studentfilestorageFacade.Updatereg_studentfilestorage"));
            }
		}
		
		async Task<long> Ireg_studentfilestorageFacadeObjects.Add(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().Add(reg_studentfilestorage, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_studentfilestorageFacade.Addreg_studentfilestorage"));
            }
		}
		
        async Task<long> Ireg_studentfilestorageFacadeObjects.SaveList(List<reg_studentfilestorageEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_studentfilestorageEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_studentfilestorageEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_studentfilestorageEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_studentfilestorageDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_studentfilestorage"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageFacadeObjects.GetAll(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().GetAll(reg_studentfilestorage, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_studentfilestorageEntity> Ireg_studentfilestorageFacade.GetAllreg_studentfilestorage"));
            }
		}
		
		async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageFacadeObjects.GetAllByPages(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().GetAllByPages(reg_studentfilestorage,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_studentfilestorageEntity> Ireg_studentfilestorageFacade.GetAllByPagesreg_studentfilestorage"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_studentfilestorageEntity>  Ireg_studentfilestorageFacadeObjects.GetSingle(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().GetSingle(reg_studentfilestorage,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_studentfilestorageEntity Ireg_studentfilestorageFacade.GetSinglereg_studentfilestorage"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_studentfilestorageEntity>> Ireg_studentfilestorageFacadeObjects.GAPgListView(reg_studentfilestorageEntity reg_studentfilestorage, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_studentfilestorageDataAccess().GAPgListView(reg_studentfilestorage,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_studentfilestorageEntity> Ireg_studentfilestorageFacade.GAPgListViewreg_studentfilestorage"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}