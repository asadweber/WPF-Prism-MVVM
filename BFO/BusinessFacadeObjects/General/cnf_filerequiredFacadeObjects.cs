
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
    public sealed partial class cnf_filerequiredFacadeObjects : BaseFacade, Icnf_filerequiredFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_filerequiredFacadeObjects";
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

        public cnf_filerequiredFacadeObjects()
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

        ~cnf_filerequiredFacadeObjects()
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
		
		async Task<long> Icnf_filerequiredFacadeObjects.Delete(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().Delete(cnf_filerequired, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_filerequiredFacade.Deletecnf_filerequired"));
            }
        }
		
		async Task<long> Icnf_filerequiredFacadeObjects.Update(cnf_filerequiredEntity cnf_filerequired , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().Update(cnf_filerequired,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_filerequiredFacade.Updatecnf_filerequired"));
            }
		}
		
		async Task<long> Icnf_filerequiredFacadeObjects.Add(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().Add(cnf_filerequired, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_filerequiredFacade.Addcnf_filerequired"));
            }
		}
		
        async Task<long> Icnf_filerequiredFacadeObjects.SaveList(List<cnf_filerequiredEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_filerequiredEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_filerequiredEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_filerequiredEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_filerequiredDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_filerequired"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredFacadeObjects.GetAll(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().GetAll(cnf_filerequired, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_filerequiredEntity> Icnf_filerequiredFacade.GetAllcnf_filerequired"));
            }
		}
		
		async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredFacadeObjects.GetAllByPages(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().GetAllByPages(cnf_filerequired,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_filerequiredEntity> Icnf_filerequiredFacade.GetAllByPagescnf_filerequired"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Icnf_filerequiredFacadeObjects.SaveMasterDetgen_batchcandidatereqfile(cnf_filerequiredEntity Master, List<gen_batchcandidatereqfileEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_batchcandidatereqfileEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_batchcandidatereqfileEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_batchcandidatereqfileEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createcnf_filerequiredDataAccess().SaveMasterDetgen_batchcandidatereqfile(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandidatereqfile"));
               }
        }
        
        
        async Task<long> Icnf_filerequiredFacadeObjects.SaveMasterDetreg_studentfilestorage(cnf_filerequiredEntity Master, List<reg_studentfilestorageEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createcnf_filerequiredDataAccess().SaveMasterDetreg_studentfilestorage(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_studentfilestorage"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_filerequiredEntity>  Icnf_filerequiredFacadeObjects.GetSingle(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().GetSingle(cnf_filerequired,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_filerequiredEntity Icnf_filerequiredFacade.GetSinglecnf_filerequired"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredFacadeObjects.GAPgListView(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().GAPgListView(cnf_filerequired,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_filerequiredEntity> Icnf_filerequiredFacade.GAPgListViewcnf_filerequired"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_filerequiredFacadeObjects.GetDataForDropDown(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().GetDataForDropDown(cnf_filerequired,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<cnf_filerequiredEntity> Icnf_filerequiredFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}