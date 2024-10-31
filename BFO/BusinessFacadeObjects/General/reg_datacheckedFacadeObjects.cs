
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
    public sealed partial class reg_datacheckedFacadeObjects : BaseFacade, Ireg_datacheckedFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_datacheckedFacadeObjects";
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

        public reg_datacheckedFacadeObjects()
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

        ~reg_datacheckedFacadeObjects()
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
		
		async Task<long> Ireg_datacheckedFacadeObjects.Delete(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_datacheckedDataAccess().Delete(reg_datachecked, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_datacheckedFacade.Deletereg_datachecked"));
            }
        }
		
		async Task<long> Ireg_datacheckedFacadeObjects.Update(reg_datacheckedEntity reg_datachecked , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().Update(reg_datachecked,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_datacheckedFacade.Updatereg_datachecked"));
            }
		}
		
		async Task<long> Ireg_datacheckedFacadeObjects.Add(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().Add(reg_datachecked, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_datacheckedFacade.Addreg_datachecked"));
            }
		}
		
        async Task<long> Ireg_datacheckedFacadeObjects.SaveList(List<reg_datacheckedEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_datacheckedEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_datacheckedEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_datacheckedEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_datacheckedDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_datachecked"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_datacheckedEntity>> Ireg_datacheckedFacadeObjects.GetAll(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().GetAll(reg_datachecked, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_datacheckedEntity> Ireg_datacheckedFacade.GetAllreg_datachecked"));
            }
		}
		
		async Task<IList<reg_datacheckedEntity>> Ireg_datacheckedFacadeObjects.GetAllByPages(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().GetAllByPages(reg_datachecked,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_datacheckedEntity> Ireg_datacheckedFacade.GetAllByPagesreg_datachecked"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Ireg_datacheckedFacadeObjects.SaveMasterDetreg_datachecked(reg_datacheckedEntity Master, List<reg_datacheckedEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_datacheckedEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_datacheckedEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_datacheckedEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_datacheckedDataAccess().SaveMasterDetreg_datachecked(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_datachecked"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_datacheckedEntity>  Ireg_datacheckedFacadeObjects.GetSingle(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().GetSingle(reg_datachecked,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_datacheckedEntity Ireg_datacheckedFacade.GetSinglereg_datachecked"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_datacheckedEntity>> Ireg_datacheckedFacadeObjects.GAPgListView(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().GAPgListView(reg_datachecked,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_datacheckedEntity> Ireg_datacheckedFacade.GAPgListViewreg_datachecked"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_datacheckedFacadeObjects.GetDataForDropDown(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().GetDataForDropDown(reg_datachecked,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<reg_datacheckedEntity> Ireg_datacheckedFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}