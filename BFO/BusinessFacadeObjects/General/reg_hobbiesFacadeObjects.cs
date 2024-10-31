
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
    public sealed partial class reg_hobbiesFacadeObjects : BaseFacade, Ireg_hobbiesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_hobbiesFacadeObjects";
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

        public reg_hobbiesFacadeObjects()
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

        ~reg_hobbiesFacadeObjects()
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
		
		async Task<long> Ireg_hobbiesFacadeObjects.Delete(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_hobbiesDataAccess().Delete(reg_hobbies, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_hobbiesFacade.Deletereg_hobbies"));
            }
        }
		
		async Task<long> Ireg_hobbiesFacadeObjects.Update(reg_hobbiesEntity reg_hobbies , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().Update(reg_hobbies,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_hobbiesFacade.Updatereg_hobbies"));
            }
		}
		
		async Task<long> Ireg_hobbiesFacadeObjects.Add(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().Add(reg_hobbies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_hobbiesFacade.Addreg_hobbies"));
            }
		}
		
        async Task<long> Ireg_hobbiesFacadeObjects.SaveList(List<reg_hobbiesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_hobbiesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_hobbiesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_hobbiesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_hobbiesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_hobbies"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesFacadeObjects.GetAll(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().GetAll(reg_hobbies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_hobbiesEntity> Ireg_hobbiesFacade.GetAllreg_hobbies"));
            }
		}
		
		async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesFacadeObjects.GetAllByPages(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().GetAllByPages(reg_hobbies,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_hobbiesEntity> Ireg_hobbiesFacade.GetAllByPagesreg_hobbies"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_hobbiesEntity>  Ireg_hobbiesFacadeObjects.GetSingle(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().GetSingle(reg_hobbies,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_hobbiesEntity Ireg_hobbiesFacade.GetSinglereg_hobbies"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_hobbiesEntity>> Ireg_hobbiesFacadeObjects.GAPgListView(reg_hobbiesEntity reg_hobbies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_hobbiesDataAccess().GAPgListView(reg_hobbies,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_hobbiesEntity> Ireg_hobbiesFacade.GAPgListViewreg_hobbies"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}