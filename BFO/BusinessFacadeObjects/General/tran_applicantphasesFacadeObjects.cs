
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
    public sealed partial class tran_applicantphasesFacadeObjects : BaseFacade, Itran_applicantphasesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_applicantphasesFacadeObjects";
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

        public tran_applicantphasesFacadeObjects()
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

        ~tran_applicantphasesFacadeObjects()
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
		
		async Task<long> Itran_applicantphasesFacadeObjects.Delete(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().Delete(tran_applicantphases, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantphasesFacade.Deletetran_applicantphases"));
            }
        }
		
		async Task<long> Itran_applicantphasesFacadeObjects.Update(tran_applicantphasesEntity tran_applicantphases , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().Update(tran_applicantphases,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_applicantphasesFacade.Updatetran_applicantphases"));
            }
		}
		
		async Task<long> Itran_applicantphasesFacadeObjects.Add(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().Add(tran_applicantphases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantphasesFacade.Addtran_applicantphases"));
            }
		}
		
        async Task<long> Itran_applicantphasesFacadeObjects.SaveList(List<tran_applicantphasesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_applicantphasesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_applicantphasesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_applicantphasesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_applicantphasesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_applicantphases"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesFacadeObjects.GetAll(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().GetAll(tran_applicantphases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantphasesEntity> Itran_applicantphasesFacade.GetAlltran_applicantphases"));
            }
		}
		
		async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesFacadeObjects.GetAllByPages(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().GetAllByPages(tran_applicantphases,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantphasesEntity> Itran_applicantphasesFacade.GetAllByPagestran_applicantphases"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Itran_applicantphasesFacadeObjects.SaveMasterDettran_notificationbatchdet(tran_applicantphasesEntity Master, List<tran_notificationbatchdetEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createtran_applicantphasesDataAccess().SaveMasterDettran_notificationbatchdet(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_notificationbatchdet"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_applicantphasesEntity>  Itran_applicantphasesFacadeObjects.GetSingle(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().GetSingle(tran_applicantphases,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_applicantphasesEntity Itran_applicantphasesFacade.GetSingletran_applicantphases"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesFacadeObjects.GAPgListView(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().GAPgListView(tran_applicantphases,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantphasesEntity> Itran_applicantphasesFacade.GAPgListViewtran_applicantphases"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Itran_applicantphasesFacadeObjects.GetDataForDropDown(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().GetDataForDropDown(tran_applicantphases,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<tran_applicantphasesEntity> Itran_applicantphasesFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}