
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
    public sealed partial class reg_previousexperianceFacadeObjects : BaseFacade, Ireg_previousexperianceFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_previousexperianceFacadeObjects";
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

        public reg_previousexperianceFacadeObjects()
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

        ~reg_previousexperianceFacadeObjects()
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
		
		async Task<long> Ireg_previousexperianceFacadeObjects.Delete(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().Delete(reg_previousexperiance, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_previousexperianceFacade.Deletereg_previousexperiance"));
            }
        }
		
		async Task<long> Ireg_previousexperianceFacadeObjects.Update(reg_previousexperianceEntity reg_previousexperiance , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().Update(reg_previousexperiance,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_previousexperianceFacade.Updatereg_previousexperiance"));
            }
		}
		
		async Task<long> Ireg_previousexperianceFacadeObjects.Add(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().Add(reg_previousexperiance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_previousexperianceFacade.Addreg_previousexperiance"));
            }
		}
		
        async Task<long> Ireg_previousexperianceFacadeObjects.SaveList(List<reg_previousexperianceEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_previousexperianceEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_previousexperianceEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_previousexperianceEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_previousexperianceDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_previousexperiance"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceFacadeObjects.GetAll(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().GetAll(reg_previousexperiance, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_previousexperianceEntity> Ireg_previousexperianceFacade.GetAllreg_previousexperiance"));
            }
		}
		
		async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceFacadeObjects.GetAllByPages(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().GetAllByPages(reg_previousexperiance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_previousexperianceEntity> Ireg_previousexperianceFacade.GetAllByPagesreg_previousexperiance"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_previousexperianceEntity>  Ireg_previousexperianceFacadeObjects.GetSingle(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().GetSingle(reg_previousexperiance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_previousexperianceEntity Ireg_previousexperianceFacade.GetSinglereg_previousexperiance"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_previousexperianceEntity>> Ireg_previousexperianceFacadeObjects.GAPgListView(reg_previousexperianceEntity reg_previousexperiance, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_previousexperianceDataAccess().GAPgListView(reg_previousexperiance,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_previousexperianceEntity> Ireg_previousexperianceFacade.GAPgListViewreg_previousexperiance"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}