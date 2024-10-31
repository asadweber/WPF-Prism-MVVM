
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
    public sealed partial class gen_statusFacadeObjects : BaseFacade, Igen_statusFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_statusFacadeObjects";
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

        public gen_statusFacadeObjects()
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

        ~gen_statusFacadeObjects()
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
		
		async Task<long> Igen_statusFacadeObjects.Delete(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_statusDataAccess().Delete(gen_status, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_statusFacade.Deletegen_status"));
            }
        }
		
		async Task<long> Igen_statusFacadeObjects.Update(gen_statusEntity gen_status , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().Update(gen_status,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_statusFacade.Updategen_status"));
            }
		}
		
		async Task<long> Igen_statusFacadeObjects.Add(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().Add(gen_status, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_statusFacade.Addgen_status"));
            }
		}
		
        async Task<long> Igen_statusFacadeObjects.SaveList(List<gen_statusEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_statusEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_statusEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_statusEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_statusDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_status"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_statusEntity>> Igen_statusFacadeObjects.GetAll(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().GetAll(gen_status, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_statusEntity> Igen_statusFacade.GetAllgen_status"));
            }
		}
		
		async Task<IList<gen_statusEntity>> Igen_statusFacadeObjects.GetAllByPages(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().GetAllByPages(gen_status,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_statusEntity> Igen_statusFacade.GetAllByPagesgen_status"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_statusFacadeObjects.SaveMasterDetcnf_notificationconfig(gen_statusEntity Master, List<cnf_notificationconfigEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_statusDataAccess().SaveMasterDetcnf_notificationconfig(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_notificationconfig"));
               }
        }
        
        
        async Task<long> Igen_statusFacadeObjects.SaveMasterDettran_applicantphases(gen_statusEntity Master, List<tran_applicantphasesEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_statusDataAccess().SaveMasterDettran_applicantphases(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_applicantphases"));
               }
        }
        
        
        async Task<long> Igen_statusFacadeObjects.SaveMasterDettran_notificationbatch(gen_statusEntity Master, List<tran_notificationbatchEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_statusDataAccess().SaveMasterDettran_notificationbatch(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatch"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_statusEntity>  Igen_statusFacadeObjects.GetSingle(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().GetSingle(gen_status,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_statusEntity Igen_statusFacade.GetSinglegen_status"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_statusEntity>> Igen_statusFacadeObjects.GAPgListView(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().GAPgListView(gen_status,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_statusEntity> Igen_statusFacade.GAPgListViewgen_status"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_statusFacadeObjects.GetDataForDropDown(gen_statusEntity gen_status, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_statusDataAccess().GetDataForDropDown(gen_status,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_statusEntity> Igen_statusFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}