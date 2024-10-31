
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
    public sealed partial class reg_emergencycontactinfoFacadeObjects : BaseFacade, Ireg_emergencycontactinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_emergencycontactinfoFacadeObjects";
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

        public reg_emergencycontactinfoFacadeObjects()
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

        ~reg_emergencycontactinfoFacadeObjects()
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
		
		async Task<long> Ireg_emergencycontactinfoFacadeObjects.Delete(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().Delete(reg_emergencycontactinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.Deletereg_emergencycontactinfo"));
            }
        }
		
		async Task<long> Ireg_emergencycontactinfoFacadeObjects.Update(reg_emergencycontactinfoEntity reg_emergencycontactinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().Update(reg_emergencycontactinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.Updatereg_emergencycontactinfo"));
            }
		}
		
		async Task<long> Ireg_emergencycontactinfoFacadeObjects.Add(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().Add(reg_emergencycontactinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_emergencycontactinfoFacade.Addreg_emergencycontactinfo"));
            }
		}
		
        async Task<long> Ireg_emergencycontactinfoFacadeObjects.SaveList(List<reg_emergencycontactinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_emergencycontactinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_emergencycontactinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_emergencycontactinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_emergencycontactinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoFacadeObjects.GetAll(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GetAll(reg_emergencycontactinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoFacade.GetAllreg_emergencycontactinfo"));
            }
		}
		
		async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoFacadeObjects.GetAllByPages(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GetAllByPages(reg_emergencycontactinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoFacade.GetAllByPagesreg_emergencycontactinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Ireg_emergencycontactinfoFacadeObjects.SaveMasterDetreg_relativesworkinginmod(reg_emergencycontactinfoEntity Master, List<reg_relativesworkinginmodEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_relativesworkinginmodEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_relativesworkinginmodEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_relativesworkinginmodEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().SaveMasterDetreg_relativesworkinginmod(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_relativesworkinginmod"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_emergencycontactinfoEntity>  Ireg_emergencycontactinfoFacadeObjects.GetSingle(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GetSingle(reg_emergencycontactinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_emergencycontactinfoEntity Ireg_emergencycontactinfoFacade.GetSinglereg_emergencycontactinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_emergencycontactinfoEntity>> Ireg_emergencycontactinfoFacadeObjects.GAPgListView(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GAPgListView(reg_emergencycontactinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoFacade.GAPgListViewreg_emergencycontactinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_emergencycontactinfoFacadeObjects.GetDataForDropDown(reg_emergencycontactinfoEntity reg_emergencycontactinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_emergencycontactinfoDataAccess().GetDataForDropDown(reg_emergencycontactinfo,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<reg_emergencycontactinfoEntity> Ireg_emergencycontactinfoFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}