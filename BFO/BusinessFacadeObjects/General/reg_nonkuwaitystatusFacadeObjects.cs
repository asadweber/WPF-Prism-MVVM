
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
    public sealed partial class reg_nonkuwaitystatusFacadeObjects : BaseFacade, Ireg_nonkuwaitystatusFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_nonkuwaitystatusFacadeObjects";
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

        public reg_nonkuwaitystatusFacadeObjects()
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

        ~reg_nonkuwaitystatusFacadeObjects()
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
		
		async Task<long> Ireg_nonkuwaitystatusFacadeObjects.Delete(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().Delete(reg_nonkuwaitystatus, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_nonkuwaitystatusFacade.Deletereg_nonkuwaitystatus"));
            }
        }
		
		async Task<long> Ireg_nonkuwaitystatusFacadeObjects.Update(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().Update(reg_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_nonkuwaitystatusFacade.Updatereg_nonkuwaitystatus"));
            }
		}
		
		async Task<long> Ireg_nonkuwaitystatusFacadeObjects.Add(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().Add(reg_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_nonkuwaitystatusFacade.Addreg_nonkuwaitystatus"));
            }
		}
		
        async Task<long> Ireg_nonkuwaitystatusFacadeObjects.SaveList(List<reg_nonkuwaitystatusEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_nonkuwaitystatusEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_nonkuwaitystatusEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_nonkuwaitystatusEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_nonkuwaitystatus"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusFacadeObjects.GetAll(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().GetAll(reg_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_nonkuwaitystatusEntity> Ireg_nonkuwaitystatusFacade.GetAllreg_nonkuwaitystatus"));
            }
		}
		
		async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusFacadeObjects.GetAllByPages(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().GetAllByPages(reg_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_nonkuwaitystatusEntity> Ireg_nonkuwaitystatusFacade.GetAllByPagesreg_nonkuwaitystatus"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_nonkuwaitystatusEntity>  Ireg_nonkuwaitystatusFacadeObjects.GetSingle(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().GetSingle(reg_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_nonkuwaitystatusEntity Ireg_nonkuwaitystatusFacade.GetSinglereg_nonkuwaitystatus"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_nonkuwaitystatusEntity>> Ireg_nonkuwaitystatusFacadeObjects.GAPgListView(reg_nonkuwaitystatusEntity reg_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_nonkuwaitystatusDataAccess().GAPgListView(reg_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_nonkuwaitystatusEntity> Ireg_nonkuwaitystatusFacade.GAPgListViewreg_nonkuwaitystatus"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}