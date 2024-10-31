
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
    public sealed partial class stp_organizationentityFacadeObjects : BaseFacade, Istp_organizationentityFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_organizationentityFacadeObjects";
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

        public stp_organizationentityFacadeObjects()
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

        ~stp_organizationentityFacadeObjects()
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
		
		async Task<long> Istp_organizationentityFacadeObjects.Delete(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createstp_organizationentityDataAccess().Delete(stp_organizationentity, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Deletestp_organizationentity"));
            }
        }
		
		async Task<long> Istp_organizationentityFacadeObjects.Update(stp_organizationentityEntity stp_organizationentity , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().Update(stp_organizationentity,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Updatestp_organizationentity"));
            }
		}
		
		async Task<long> Istp_organizationentityFacadeObjects.Add(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().Add(stp_organizationentity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Addstp_organizationentity"));
            }
		}
		
        async Task<long> Istp_organizationentityFacadeObjects.SaveList(List<stp_organizationentityEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<stp_organizationentityEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<stp_organizationentityEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<stp_organizationentityEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createstp_organizationentityDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_organizationentity"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<stp_organizationentityEntity>> Istp_organizationentityFacadeObjects.GetAll(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().GetAll(stp_organizationentity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GetAllstp_organizationentity"));
            }
		}
		
		async Task<IList<stp_organizationentityEntity>> Istp_organizationentityFacadeObjects.GetAllByPages(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().GetAllByPages(stp_organizationentity,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GetAllByPagesstp_organizationentity"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Istp_organizationentityFacadeObjects.SaveMasterDetreg_relativesworkinginmod(stp_organizationentityEntity Master, List<reg_relativesworkinginmodEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDetreg_relativesworkinginmod(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_relativesworkinginmod"));
               }
        }
        
        
        async Task<long> Istp_organizationentityFacadeObjects.SaveMasterDetstp_organizationentity(stp_organizationentityEntity Master, List<stp_organizationentityEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<stp_organizationentityEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<stp_organizationentityEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<stp_organizationentityEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createstp_organizationentityDataAccess().SaveMasterDetstp_organizationentity(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetstp_organizationentity"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<stp_organizationentityEntity>  Istp_organizationentityFacadeObjects.GetSingle(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().GetSingle(stp_organizationentity,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("stp_organizationentityEntity Istp_organizationentityFacade.GetSinglestp_organizationentity"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<stp_organizationentityEntity>> Istp_organizationentityFacadeObjects.GAPgListView(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().GAPgListView(stp_organizationentity,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GAPgListViewstp_organizationentity"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Istp_organizationentityFacadeObjects.GetDataForDropDown(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().GetDataForDropDown(stp_organizationentity,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}