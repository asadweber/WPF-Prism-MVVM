
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
    public sealed partial class reg_famillyFacadeObjects : BaseFacade, Ireg_famillyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_famillyFacadeObjects";
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

        public reg_famillyFacadeObjects()
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

        ~reg_famillyFacadeObjects()
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
		
		async Task<long> Ireg_famillyFacadeObjects.Delete(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_famillyDataAccess().Delete(reg_familly, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.Deletereg_familly"));
            }
        }
		
		async Task<long> Ireg_famillyFacadeObjects.Update(reg_famillyEntity reg_familly , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().Update(reg_familly,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.Updatereg_familly"));
            }
		}
		
		async Task<long> Ireg_famillyFacadeObjects.Add(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().Add(reg_familly, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_famillyFacade.Addreg_familly"));
            }
		}
		
        async Task<long> Ireg_famillyFacadeObjects.SaveList(List<reg_famillyEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_famillyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_famillyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_famillyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_famillyDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_familly"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.GetAll(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().GetAll(reg_familly, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetAllreg_familly"));
            }
		}
		
		async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.GetAllByPages(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().GetAllByPages(reg_familly,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetAllByPagesreg_familly"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Ireg_famillyFacadeObjects.SaveMasterDetreg_familly(reg_famillyEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_famillyEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_famillyEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_famillyEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_famillyDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        async Task<long> Ireg_famillyFacadeObjects.SaveMasterDetreg_nonkuwaitystatus(reg_famillyEntity Master, List<reg_nonkuwaitystatusEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_nonkuwaitystatusEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_nonkuwaitystatusEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_nonkuwaitystatusEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_famillyDataAccess().SaveMasterDetreg_nonkuwaitystatus(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_nonkuwaitystatus"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_famillyEntity>  Ireg_famillyFacadeObjects.GetSingle(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().GetSingle(reg_familly,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_famillyEntity Ireg_famillyFacade.GetSinglereg_familly"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_famillyEntity>> Ireg_famillyFacadeObjects.GAPgListView(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().GAPgListView(reg_familly,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GAPgListViewreg_familly"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_famillyFacadeObjects.GetDataForDropDown(reg_famillyEntity reg_familly, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_famillyDataAccess().GetDataForDropDown(reg_familly,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<reg_famillyEntity> Ireg_famillyFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}