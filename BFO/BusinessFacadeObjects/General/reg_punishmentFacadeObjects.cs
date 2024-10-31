
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
    public sealed partial class reg_punishmentFacadeObjects : BaseFacade, Ireg_punishmentFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_punishmentFacadeObjects";
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

        public reg_punishmentFacadeObjects()
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

        ~reg_punishmentFacadeObjects()
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
		
		async Task<long> Ireg_punishmentFacadeObjects.Delete(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_punishmentDataAccess().Delete(reg_punishment, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_punishmentFacade.Deletereg_punishment"));
            }
        }
		
		async Task<long> Ireg_punishmentFacadeObjects.Update(reg_punishmentEntity reg_punishment , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().Update(reg_punishment,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_punishmentFacade.Updatereg_punishment"));
            }
		}
		
		async Task<long> Ireg_punishmentFacadeObjects.Add(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().Add(reg_punishment, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_punishmentFacade.Addreg_punishment"));
            }
		}
		
        async Task<long> Ireg_punishmentFacadeObjects.SaveList(List<reg_punishmentEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_punishmentEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_punishmentEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_punishmentEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_punishmentDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_punishment"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_punishmentEntity>> Ireg_punishmentFacadeObjects.GetAll(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().GetAll(reg_punishment, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_punishmentEntity> Ireg_punishmentFacade.GetAllreg_punishment"));
            }
		}
		
		async Task<IList<reg_punishmentEntity>> Ireg_punishmentFacadeObjects.GetAllByPages(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().GetAllByPages(reg_punishment,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_punishmentEntity> Ireg_punishmentFacade.GetAllByPagesreg_punishment"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_punishmentEntity>  Ireg_punishmentFacadeObjects.GetSingle(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().GetSingle(reg_punishment,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_punishmentEntity Ireg_punishmentFacade.GetSinglereg_punishment"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_punishmentEntity>> Ireg_punishmentFacadeObjects.GAPgListView(reg_punishmentEntity reg_punishment, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_punishmentDataAccess().GAPgListView(reg_punishment,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_punishmentEntity> Ireg_punishmentFacade.GAPgListViewreg_punishment"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}