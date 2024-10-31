
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
    public sealed partial class reg_languageFacadeObjects : BaseFacade, Ireg_languageFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_languageFacadeObjects";
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

        public reg_languageFacadeObjects()
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

        ~reg_languageFacadeObjects()
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
		
		async Task<long> Ireg_languageFacadeObjects.Delete(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_languageDataAccess().Delete(reg_language, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_languageFacade.Deletereg_language"));
            }
        }
		
		async Task<long> Ireg_languageFacadeObjects.Update(reg_languageEntity reg_language , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().Update(reg_language,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_languageFacade.Updatereg_language"));
            }
		}
		
		async Task<long> Ireg_languageFacadeObjects.Add(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().Add(reg_language, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_languageFacade.Addreg_language"));
            }
		}
		
        async Task<long> Ireg_languageFacadeObjects.SaveList(List<reg_languageEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_languageEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_languageEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_languageEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_languageDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_language"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_languageEntity>> Ireg_languageFacadeObjects.GetAll(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().GetAll(reg_language, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_languageEntity> Ireg_languageFacade.GetAllreg_language"));
            }
		}
		
		async Task<IList<reg_languageEntity>> Ireg_languageFacadeObjects.GetAllByPages(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().GetAllByPages(reg_language,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_languageEntity> Ireg_languageFacade.GetAllByPagesreg_language"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_languageEntity>  Ireg_languageFacadeObjects.GetSingle(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().GetSingle(reg_language,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_languageEntity Ireg_languageFacade.GetSinglereg_language"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_languageEntity>> Ireg_languageFacadeObjects.GAPgListView(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().GAPgListView(reg_language,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_languageEntity> Ireg_languageFacade.GAPgListViewreg_language"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}