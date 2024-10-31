
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
    public sealed partial class gen_civilworkplacesFacadeObjects : BaseFacade, Igen_civilworkplacesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_civilworkplacesFacadeObjects";
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

        public gen_civilworkplacesFacadeObjects()
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

        ~gen_civilworkplacesFacadeObjects()
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
		
		async Task<long> Igen_civilworkplacesFacadeObjects.Delete(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().Delete(gen_civilworkplaces, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_civilworkplacesFacade.Deletegen_civilworkplaces"));
            }
        }
		
		async Task<long> Igen_civilworkplacesFacadeObjects.Update(gen_civilworkplacesEntity gen_civilworkplaces , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().Update(gen_civilworkplaces,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_civilworkplacesFacade.Updategen_civilworkplaces"));
            }
		}
		
		async Task<long> Igen_civilworkplacesFacadeObjects.Add(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().Add(gen_civilworkplaces, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_civilworkplacesFacade.Addgen_civilworkplaces"));
            }
		}
		
        async Task<long> Igen_civilworkplacesFacadeObjects.SaveList(List<gen_civilworkplacesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_civilworkplacesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_civilworkplacesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_civilworkplacesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_civilworkplacesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_civilworkplaces"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesFacadeObjects.GetAll(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GetAll(gen_civilworkplaces, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_civilworkplacesEntity> Igen_civilworkplacesFacade.GetAllgen_civilworkplaces"));
            }
		}
		
		async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesFacadeObjects.GetAllByPages(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GetAllByPages(gen_civilworkplaces,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_civilworkplacesEntity> Igen_civilworkplacesFacade.GetAllByPagesgen_civilworkplaces"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_civilworkplacesFacadeObjects.SaveMasterDetgen_civilworkplaces(gen_civilworkplacesEntity Master, List<gen_civilworkplacesEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_civilworkplacesDataAccess().SaveMasterDetgen_civilworkplaces(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_civilworkplaces"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_civilworkplacesEntity>  Igen_civilworkplacesFacadeObjects.GetSingle(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GetSingle(gen_civilworkplaces,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_civilworkplacesEntity Igen_civilworkplacesFacade.GetSinglegen_civilworkplaces"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_civilworkplacesEntity>> Igen_civilworkplacesFacadeObjects.GAPgListView(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GAPgListView(gen_civilworkplaces,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_civilworkplacesEntity> Igen_civilworkplacesFacade.GAPgListViewgen_civilworkplaces"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_civilworkplacesFacadeObjects.GetDataForDropDown(gen_civilworkplacesEntity gen_civilworkplaces, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_civilworkplacesDataAccess().GetDataForDropDown(gen_civilworkplaces,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_civilworkplacesEntity> Igen_civilworkplacesFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}