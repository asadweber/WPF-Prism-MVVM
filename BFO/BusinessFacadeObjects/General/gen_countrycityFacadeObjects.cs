
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
    public sealed partial class gen_countrycityFacadeObjects : BaseFacade, Igen_countrycityFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_countrycityFacadeObjects";
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

        public gen_countrycityFacadeObjects()
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

        ~gen_countrycityFacadeObjects()
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
		
		async Task<long> Igen_countrycityFacadeObjects.Delete(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_countrycityDataAccess().Delete(gen_countrycity, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countrycityFacade.Deletegen_countrycity"));
            }
        }
		
		async Task<long> Igen_countrycityFacadeObjects.Update(gen_countrycityEntity gen_countrycity , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().Update(gen_countrycity,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_countrycityFacade.Updategen_countrycity"));
            }
		}
		
		async Task<long> Igen_countrycityFacadeObjects.Add(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().Add(gen_countrycity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countrycityFacade.Addgen_countrycity"));
            }
		}
		
        async Task<long> Igen_countrycityFacadeObjects.SaveList(List<gen_countrycityEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_countrycityEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_countrycityEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_countrycityEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_countrycityDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_countrycity"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_countrycityEntity>> Igen_countrycityFacadeObjects.GetAll(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().GetAll(gen_countrycity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GetAllgen_countrycity"));
            }
		}
		
		async Task<IList<gen_countrycityEntity>> Igen_countrycityFacadeObjects.GetAllByPages(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().GetAllByPages(gen_countrycity,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GetAllByPagesgen_countrycity"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_countrycityFacadeObjects.SaveMasterDetgen_civilworkplaces(gen_countrycityEntity Master, List<gen_civilworkplacesEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_civilworkplacesEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_civilworkplacesEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_civilworkplacesEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_countrycityDataAccess().SaveMasterDetgen_civilworkplaces(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_civilworkplaces"));
               }
        }
        
        
        async Task<long> Igen_countrycityFacadeObjects.SaveMasterDetgen_countrycity(gen_countrycityEntity Master, List<gen_countrycityEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_countrycityEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_countrycityEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_countrycityEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_countrycityDataAccess().SaveMasterDetgen_countrycity(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_countrycity"));
               }
        }
        
        
        async Task<long> Igen_countrycityFacadeObjects.SaveMasterDetreg_familly(gen_countrycityEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_countrycityDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_countrycityEntity>  Igen_countrycityFacadeObjects.GetSingle(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().GetSingle(gen_countrycity,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_countrycityEntity Igen_countrycityFacade.GetSinglegen_countrycity"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_countrycityEntity>> Igen_countrycityFacadeObjects.GAPgListView(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().GAPgListView(gen_countrycity,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GAPgListViewgen_countrycity"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_countrycityFacadeObjects.GetDataForDropDown(gen_countrycityEntity gen_countrycity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countrycityDataAccess().GetDataForDropDown(gen_countrycity,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_countrycityEntity> Igen_countrycityFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}