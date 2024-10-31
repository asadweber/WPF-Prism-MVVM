
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
    public sealed partial class cnf_notificationtempletFacadeObjects : BaseFacade, Icnf_notificationtempletFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_notificationtempletFacadeObjects";
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

        public cnf_notificationtempletFacadeObjects()
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

        ~cnf_notificationtempletFacadeObjects()
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
		
		async Task<long> Icnf_notificationtempletFacadeObjects.Delete(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().Delete(cnf_notificationtemplet, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationtempletFacade.Deletecnf_notificationtemplet"));
            }
        }
		
		async Task<long> Icnf_notificationtempletFacadeObjects.Update(cnf_notificationtempletEntity cnf_notificationtemplet , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().Update(cnf_notificationtemplet,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_notificationtempletFacade.Updatecnf_notificationtemplet"));
            }
		}
		
		async Task<long> Icnf_notificationtempletFacadeObjects.Add(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().Add(cnf_notificationtemplet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_notificationtempletFacade.Addcnf_notificationtemplet"));
            }
		}
		
        async Task<long> Icnf_notificationtempletFacadeObjects.SaveList(List<cnf_notificationtempletEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_notificationtempletEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_notificationtempletEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_notificationtempletEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_notificationtempletDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_notificationtemplet"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletFacadeObjects.GetAll(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GetAll(cnf_notificationtemplet, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationtempletEntity> Icnf_notificationtempletFacade.GetAllcnf_notificationtemplet"));
            }
		}
		
		async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletFacadeObjects.GetAllByPages(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GetAllByPages(cnf_notificationtemplet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationtempletEntity> Icnf_notificationtempletFacade.GetAllByPagescnf_notificationtemplet"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Icnf_notificationtempletFacadeObjects.SaveMasterDetcnf_notificationconfigdetl(cnf_notificationtempletEntity Master, List<cnf_notificationconfigdetlEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_notificationconfigdetlEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_notificationconfigdetlEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_notificationconfigdetlEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createcnf_notificationtempletDataAccess().SaveMasterDetcnf_notificationconfigdetl(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_notificationconfigdetl"));
               }
        }
        
        
        
        
        
        async Task<long> Icnf_notificationtempletFacadeObjects.SaveMasterDettran_notificationbatchdet(cnf_notificationtempletEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createcnf_notificationtempletDataAccess().SaveMasterDettran_notificationbatchdet(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatchdet"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_notificationtempletEntity>  Icnf_notificationtempletFacadeObjects.GetSingle(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GetSingle(cnf_notificationtemplet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_notificationtempletEntity Icnf_notificationtempletFacade.GetSinglecnf_notificationtemplet"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_notificationtempletEntity>> Icnf_notificationtempletFacadeObjects.GAPgListView(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GAPgListView(cnf_notificationtemplet,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationtempletEntity> Icnf_notificationtempletFacade.GAPgListViewcnf_notificationtemplet"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_notificationtempletFacadeObjects.GetDataForDropDown(cnf_notificationtempletEntity cnf_notificationtemplet, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_notificationtempletDataAccess().GetDataForDropDown(cnf_notificationtemplet,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<cnf_notificationtempletEntity> Icnf_notificationtempletFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}