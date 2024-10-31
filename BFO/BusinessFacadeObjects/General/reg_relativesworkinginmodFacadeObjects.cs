
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
    public sealed partial class reg_relativesworkinginmodFacadeObjects : BaseFacade, Ireg_relativesworkinginmodFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_relativesworkinginmodFacadeObjects";
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

        public reg_relativesworkinginmodFacadeObjects()
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

        ~reg_relativesworkinginmodFacadeObjects()
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
		
		async Task<long> Ireg_relativesworkinginmodFacadeObjects.Delete(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().Delete(reg_relativesworkinginmod, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_relativesworkinginmodFacade.Deletereg_relativesworkinginmod"));
            }
        }
		
		async Task<long> Ireg_relativesworkinginmodFacadeObjects.Update(reg_relativesworkinginmodEntity reg_relativesworkinginmod , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().Update(reg_relativesworkinginmod,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_relativesworkinginmodFacade.Updatereg_relativesworkinginmod"));
            }
		}
		
		async Task<long> Ireg_relativesworkinginmodFacadeObjects.Add(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().Add(reg_relativesworkinginmod, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_relativesworkinginmodFacade.Addreg_relativesworkinginmod"));
            }
		}
		
        async Task<long> Ireg_relativesworkinginmodFacadeObjects.SaveList(List<reg_relativesworkinginmodEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_relativesworkinginmodEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_relativesworkinginmodEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_relativesworkinginmodEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_relativesworkinginmod"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodFacadeObjects.GetAll(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().GetAll(reg_relativesworkinginmod, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_relativesworkinginmodEntity> Ireg_relativesworkinginmodFacade.GetAllreg_relativesworkinginmod"));
            }
		}
		
		async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodFacadeObjects.GetAllByPages(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().GetAllByPages(reg_relativesworkinginmod,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_relativesworkinginmodEntity> Ireg_relativesworkinginmodFacade.GetAllByPagesreg_relativesworkinginmod"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_relativesworkinginmodEntity>  Ireg_relativesworkinginmodFacadeObjects.GetSingle(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().GetSingle(reg_relativesworkinginmod,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_relativesworkinginmodEntity Ireg_relativesworkinginmodFacade.GetSinglereg_relativesworkinginmod"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodFacadeObjects.GAPgListView(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().GAPgListView(reg_relativesworkinginmod,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_relativesworkinginmodEntity> Ireg_relativesworkinginmodFacade.GAPgListViewreg_relativesworkinginmod"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}