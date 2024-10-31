
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
    public sealed partial class reg_registrationinfoFacadeObjects : BaseFacade, Ireg_registrationinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_registrationinfoFacadeObjects";
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

        public reg_registrationinfoFacadeObjects()
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

        ~reg_registrationinfoFacadeObjects()
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
		
		async Task<long> Ireg_registrationinfoFacadeObjects.Delete(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().Delete(reg_registrationinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.Deletereg_registrationinfo"));
            }
        }
		
		async Task<long> Ireg_registrationinfoFacadeObjects.Update(reg_registrationinfoEntity reg_registrationinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().Update(reg_registrationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.Updatereg_registrationinfo"));
            }
		}
		
		async Task<long> Ireg_registrationinfoFacadeObjects.Add(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().Add(reg_registrationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_registrationinfoFacade.Addreg_registrationinfo"));
            }
		}
		
        async Task<long> Ireg_registrationinfoFacadeObjects.SaveList(List<reg_registrationinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_registrationinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_registrationinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_registrationinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_registrationinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_registrationinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetAll(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetAll(reg_registrationinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetAllreg_registrationinfo"));
            }
		}
		
		async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GetAllByPages(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetAllByPages(reg_registrationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetAllByPagesreg_registrationinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Ireg_registrationinfoFacadeObjects.SaveMasterDetreg_studentfilestorage(reg_registrationinfoEntity Master, List<reg_studentfilestorageEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_studentfilestorageEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_studentfilestorageEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_studentfilestorageEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_registrationinfoDataAccess().SaveMasterDetreg_studentfilestorage(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_studentfilestorage"));
               }
        }
        
        
        async Task<long> Ireg_registrationinfoFacadeObjects.SaveMasterDettran_applicantphases(reg_registrationinfoEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_applicantphasesEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_applicantphasesEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_applicantphasesEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_registrationinfoDataAccess().SaveMasterDettran_applicantphases(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_applicantphases"));
               }
        }
        
        
        async Task<long> Ireg_registrationinfoFacadeObjects.SaveMasterDettran_exportprofile(reg_registrationinfoEntity Master, List<tran_exportprofileEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_exportprofileEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_exportprofileEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_exportprofileEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_registrationinfoDataAccess().SaveMasterDettran_exportprofile(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_exportprofile"));
               }
        }
        
        
        async Task<long> Ireg_registrationinfoFacadeObjects.SaveMasterDettran_notificationbatchdet(reg_registrationinfoEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_notificationbatchdetEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_notificationbatchdetEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_notificationbatchdetEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_registrationinfoDataAccess().SaveMasterDettran_notificationbatchdet(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatchdet"));
               }
        }
        
        
        async Task<long> Ireg_registrationinfoFacadeObjects.SaveMasterDettran_rollbackinfo(reg_registrationinfoEntity Master, List<tran_rollbackinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_rollbackinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_rollbackinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_rollbackinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_registrationinfoDataAccess().SaveMasterDettran_rollbackinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_rollbackinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_registrationinfoEntity>  Ireg_registrationinfoFacadeObjects.GetSingle(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetSingle(reg_registrationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_registrationinfoEntity Ireg_registrationinfoFacade.GetSinglereg_registrationinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_registrationinfoEntity>> Ireg_registrationinfoFacadeObjects.GAPgListView(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().GAPgListView(reg_registrationinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GAPgListViewreg_registrationinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_registrationinfoFacadeObjects.GetDataForDropDown(reg_registrationinfoEntity reg_registrationinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_registrationinfoDataAccess().GetDataForDropDown(reg_registrationinfo,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<reg_registrationinfoEntity> Ireg_registrationinfoFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}