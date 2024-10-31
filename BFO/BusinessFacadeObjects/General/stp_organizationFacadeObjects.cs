
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
    public sealed partial class stp_organizationFacadeObjects : BaseFacade, Istp_organizationFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "stp_organizationFacadeObjects";
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

        public stp_organizationFacadeObjects()
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

        ~stp_organizationFacadeObjects()
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
		
		async Task<long> Istp_organizationFacadeObjects.Delete(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createstp_organizationDataAccess().Delete(stp_organization, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationFacade.Deletestp_organization"));
            }
        }
		
		async Task<long> Istp_organizationFacadeObjects.Update(stp_organizationEntity stp_organization , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().Update(stp_organization,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Istp_organizationFacade.Updatestp_organization"));
            }
		}
		
		async Task<long> Istp_organizationFacadeObjects.Add(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().Add(stp_organization, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationFacade.Addstp_organization"));
            }
		}
		
        async Task<long> Istp_organizationFacadeObjects.SaveList(List<stp_organizationEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<stp_organizationEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<stp_organizationEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<stp_organizationEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createstp_organizationDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_stp_organization"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<stp_organizationEntity>> Istp_organizationFacadeObjects.GetAll(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().GetAll(stp_organization, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationEntity> Istp_organizationFacade.GetAllstp_organization"));
            }
		}
		
		async Task<IList<stp_organizationEntity>> Istp_organizationFacadeObjects.GetAllByPages(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().GetAllByPages(stp_organization,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationEntity> Istp_organizationFacade.GetAllByPagesstp_organization"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Istp_organizationFacadeObjects.SaveMasterDetstp_organizationentity(stp_organizationEntity Master, List<stp_organizationentityEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createstp_organizationDataAccess().SaveMasterDetstp_organizationentity(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetstp_organizationentity"));
               }
        }
        
        
        async Task<long> Istp_organizationFacadeObjects.SaveMasterDetstp_organizationentitytype(stp_organizationEntity Master, List<stp_organizationentitytypeEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<stp_organizationentitytypeEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<stp_organizationentitytypeEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<stp_organizationentitytypeEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createstp_organizationDataAccess().SaveMasterDetstp_organizationentitytype(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetstp_organizationentitytype"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<stp_organizationEntity>  Istp_organizationFacadeObjects.GetSingle(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().GetSingle(stp_organization,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("stp_organizationEntity Istp_organizationFacade.GetSinglestp_organization"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<stp_organizationEntity>> Istp_organizationFacadeObjects.GAPgListView(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().GAPgListView(stp_organization,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationEntity> Istp_organizationFacade.GAPgListViewstp_organization"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Istp_organizationFacadeObjects.GetDataForDropDown(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().GetDataForDropDown(stp_organization,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<stp_organizationEntity> Istp_organizationFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}