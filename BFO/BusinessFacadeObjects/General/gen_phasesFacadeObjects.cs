
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
    public sealed partial class gen_phasesFacadeObjects : BaseFacade, Igen_phasesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_phasesFacadeObjects";
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

        public gen_phasesFacadeObjects()
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

        ~gen_phasesFacadeObjects()
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
		
		async Task<long> Igen_phasesFacadeObjects.Delete(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_phasesDataAccess().Delete(gen_phases, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_phasesFacade.Deletegen_phases"));
            }
        }
		
		async Task<long> Igen_phasesFacadeObjects.Update(gen_phasesEntity gen_phases , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().Update(gen_phases,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_phasesFacade.Updategen_phases"));
            }
		}
		
		async Task<long> Igen_phasesFacadeObjects.Add(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().Add(gen_phases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_phasesFacade.Addgen_phases"));
            }
		}
		
        async Task<long> Igen_phasesFacadeObjects.SaveList(List<gen_phasesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_phasesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_phasesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_phasesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_phasesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_phases"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_phasesEntity>> Igen_phasesFacadeObjects.GetAll(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().GetAll(gen_phases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_phasesEntity> Igen_phasesFacade.GetAllgen_phases"));
            }
		}
		
		async Task<IList<gen_phasesEntity>> Igen_phasesFacadeObjects.GetAllByPages(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().GetAllByPages(gen_phases,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_phasesEntity> Igen_phasesFacade.GetAllByPagesgen_phases"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_phasesFacadeObjects.SaveMasterDetcnf_notificationconfig(gen_phasesEntity Master, List<cnf_notificationconfigEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_notificationconfigEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_notificationconfigEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_notificationconfigEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_phasesDataAccess().SaveMasterDetcnf_notificationconfig(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_notificationconfig"));
               }
        }
        
        
        async Task<long> Igen_phasesFacadeObjects.SaveMasterDetgen_phases(gen_phasesEntity Master, List<gen_phasesEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_phasesEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_phasesEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_phasesEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_phasesDataAccess().SaveMasterDetgen_phases(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_phases"));
               }
        }
        
        
        async Task<long> Igen_phasesFacadeObjects.SaveMasterDettran_applicantphases(gen_phasesEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_phasesDataAccess().SaveMasterDettran_applicantphases(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_applicantphases"));
               }
        }
        
        
        async Task<long> Igen_phasesFacadeObjects.SaveMasterDettran_notificationbatch(gen_phasesEntity Master, List<tran_notificationbatchEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_notificationbatchEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_notificationbatchEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_notificationbatchEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_phasesDataAccess().SaveMasterDettran_notificationbatch(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatch"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_phasesEntity>  Igen_phasesFacadeObjects.GetSingle(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().GetSingle(gen_phases,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_phasesEntity Igen_phasesFacade.GetSinglegen_phases"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_phasesEntity>> Igen_phasesFacadeObjects.GAPgListView(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().GAPgListView(gen_phases,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_phasesEntity> Igen_phasesFacade.GAPgListViewgen_phases"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_phasesFacadeObjects.GetDataForDropDown(gen_phasesEntity gen_phases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_phasesDataAccess().GetDataForDropDown(gen_phases,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_phasesEntity> Igen_phasesFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}