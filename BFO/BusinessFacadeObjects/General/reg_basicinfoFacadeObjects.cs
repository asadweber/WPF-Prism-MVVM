
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
    public sealed partial class reg_basicinfoFacadeObjects : BaseFacade, Ireg_basicinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "reg_basicinfoFacadeObjects";
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

        public reg_basicinfoFacadeObjects()
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

        ~reg_basicinfoFacadeObjects()
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
		
		async Task<long> Ireg_basicinfoFacadeObjects.Delete(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createreg_basicinfoDataAccess().Delete(reg_basicinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.Deletereg_basicinfo"));
            }
        }
		
		async Task<long> Ireg_basicinfoFacadeObjects.Update(reg_basicinfoEntity reg_basicinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().Update(reg_basicinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.Updatereg_basicinfo"));
            }
		}
		
		async Task<long> Ireg_basicinfoFacadeObjects.Add(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().Add(reg_basicinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_basicinfoFacade.Addreg_basicinfo"));
            }
		}
		
        async Task<long> Ireg_basicinfoFacadeObjects.SaveList(List<reg_basicinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<reg_basicinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<reg_basicinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<reg_basicinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_reg_basicinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoFacadeObjects.GetAll(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().GetAll(reg_basicinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetAllreg_basicinfo"));
            }
		}
		
		async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoFacadeObjects.GetAllByPages(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().GetAllByPages(reg_basicinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetAllByPagesreg_basicinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetcnf_smsactivationcode(reg_basicinfoEntity Master, List<cnf_smsactivationcodeEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_smsactivationcodeEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_smsactivationcodeEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_smsactivationcodeEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetcnf_smsactivationcode(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_smsactivationcode"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetcnf_studentmenuskipdetail(reg_basicinfoEntity Master, List<cnf_studentmenuskipdetailEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_studentmenuskipdetailEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_studentmenuskipdetailEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_studentmenuskipdetailEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetcnf_studentmenuskipdetail(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_studentmenuskipdetail"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_educationinfo(reg_basicinfoEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_educationinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_educationinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_educationinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_educationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_educationinfo"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_familly(reg_basicinfoEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_hobbies(reg_basicinfoEntity Master, List<reg_hobbiesEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_hobbiesEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_hobbiesEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_hobbiesEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_hobbies(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_hobbies"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_language(reg_basicinfoEntity Master, List<reg_languageEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_languageEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_languageEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_languageEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_language(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_language"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_nonkuwaitystatus(reg_basicinfoEntity Master, List<reg_nonkuwaitystatusEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_nonkuwaitystatus(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_nonkuwaitystatus"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_previousexperiance(reg_basicinfoEntity Master, List<reg_previousexperianceEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_previousexperianceEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_previousexperianceEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_previousexperianceEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_previousexperiance(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_previousexperiance"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_punishment(reg_basicinfoEntity Master, List<reg_punishmentEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_punishmentEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_punishmentEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_punishmentEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_punishment(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_punishment"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_registrationinfo(reg_basicinfoEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_registrationinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_registrationinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_registrationinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_registrationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_registrationinfo"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_relativesworkinginmod(reg_basicinfoEntity Master, List<reg_relativesworkinginmodEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_relativesworkinginmod(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_relativesworkinginmod"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDetreg_studentfilestorage(reg_basicinfoEntity Master, List<reg_studentfilestorageEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDetreg_studentfilestorage(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_studentfilestorage"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDettran_applicantphases(reg_basicinfoEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDettran_applicantphases(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_applicantphases"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDettran_exportprofile(reg_basicinfoEntity Master, List<tran_exportprofileEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDettran_exportprofile(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_exportprofile"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDettran_notificationbatchdet(reg_basicinfoEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDettran_notificationbatchdet(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatchdet"));
               }
        }
        
        
        async Task<long> Ireg_basicinfoFacadeObjects.SaveMasterDettran_rollbackinfo(reg_basicinfoEntity Master, List<tran_rollbackinfoEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createreg_basicinfoDataAccess().SaveMasterDettran_rollbackinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_rollbackinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<reg_basicinfoEntity>  Ireg_basicinfoFacadeObjects.GetSingle(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().GetSingle(reg_basicinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_basicinfoEntity Ireg_basicinfoFacade.GetSinglereg_basicinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<reg_basicinfoEntity>> Ireg_basicinfoFacadeObjects.GAPgListView(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().GAPgListView(reg_basicinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GAPgListViewreg_basicinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Ireg_basicinfoFacadeObjects.GetDataForDropDown(reg_basicinfoEntity reg_basicinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_basicinfoDataAccess().GetDataForDropDown(reg_basicinfo,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<reg_basicinfoEntity> Ireg_basicinfoFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}