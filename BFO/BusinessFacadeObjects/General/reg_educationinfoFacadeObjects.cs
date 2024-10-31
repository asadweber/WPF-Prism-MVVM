
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
    public sealed partial class reg_educationinfoFacadeObjects : BaseFacade, Ireg_educationinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_educationinfoFacadeObjects";
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

        public reg_educationinfoFacadeObjects()
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

        ~reg_educationinfoFacadeObjects()
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
		
		async Task<long> Ireg_educationinfoFacadeObjects.Delete(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_educationinfoDataAccess().Delete(reg_educationinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.Deletereg_educationinfo"));
            }
        }
		
		async Task<long> Ireg_educationinfoFacadeObjects.Update(reg_educationinfoEntity reg_educationinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().Update(reg_educationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.Updatereg_educationinfo"));
            }
		}
		
		async Task<long> Ireg_educationinfoFacadeObjects.Add(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().Add(reg_educationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_educationinfoFacade.Addreg_educationinfo"));
            }
		}
		
        async Task<long> Ireg_educationinfoFacadeObjects.SaveList(List<reg_educationinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_educationinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_educationinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_educationinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_educationinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_educationinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoFacadeObjects.GetAll(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().GetAll(reg_educationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_educationinfoEntity> Ireg_educationinfoFacade.GetAllreg_educationinfo"));
            }
		}
		
		async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoFacadeObjects.GetAllByPages(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().GetAllByPages(reg_educationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_educationinfoEntity> Ireg_educationinfoFacade.GetAllByPagesreg_educationinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_educationinfoEntity>  Ireg_educationinfoFacadeObjects.GetSingle(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().GetSingle(reg_educationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_educationinfoEntity Ireg_educationinfoFacade.GetSinglereg_educationinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_educationinfoEntity>> Ireg_educationinfoFacadeObjects.GAPgListView(reg_educationinfoEntity reg_educationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_educationinfoDataAccess().GAPgListView(reg_educationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_educationinfoEntity> Ireg_educationinfoFacade.GAPgListViewreg_educationinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}