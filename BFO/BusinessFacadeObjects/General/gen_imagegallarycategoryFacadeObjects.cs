
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
    public sealed partial class gen_imagegallarycategoryFacadeObjects : BaseFacade, Igen_imagegallarycategoryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_imagegallarycategoryFacadeObjects";
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

        public gen_imagegallarycategoryFacadeObjects()
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

        ~gen_imagegallarycategoryFacadeObjects()
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
		
		async Task<long> Igen_imagegallarycategoryFacadeObjects.Delete(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().Delete(gen_imagegallarycategory, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_imagegallarycategoryFacade.Deletegen_imagegallarycategory"));
            }
        }
		
		async Task<long> Igen_imagegallarycategoryFacadeObjects.Update(gen_imagegallarycategoryEntity gen_imagegallarycategory , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().Update(gen_imagegallarycategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_imagegallarycategoryFacade.Updategen_imagegallarycategory"));
            }
		}
		
		async Task<long> Igen_imagegallarycategoryFacadeObjects.Add(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().Add(gen_imagegallarycategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_imagegallarycategoryFacade.Addgen_imagegallarycategory"));
            }
		}
		
        async Task<long> Igen_imagegallarycategoryFacadeObjects.SaveList(List<gen_imagegallarycategoryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_imagegallarycategoryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_imagegallarycategoryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_imagegallarycategoryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_imagegallarycategory"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryFacadeObjects.GetAll(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().GetAll(gen_imagegallarycategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallarycategoryEntity> Igen_imagegallarycategoryFacade.GetAllgen_imagegallarycategory"));
            }
		}
		
		async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryFacadeObjects.GetAllByPages(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().GetAllByPages(gen_imagegallarycategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallarycategoryEntity> Igen_imagegallarycategoryFacade.GetAllByPagesgen_imagegallarycategory"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_imagegallarycategoryFacadeObjects.SaveMasterDetgen_imagegallary(gen_imagegallarycategoryEntity Master, List<gen_imagegallaryEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_imagegallaryEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_imagegallaryEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_imagegallaryEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().SaveMasterDetgen_imagegallary(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_imagegallary"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_imagegallarycategoryEntity>  Igen_imagegallarycategoryFacadeObjects.GetSingle(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().GetSingle(gen_imagegallarycategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_imagegallarycategoryEntity Igen_imagegallarycategoryFacade.GetSinglegen_imagegallarycategory"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_imagegallarycategoryEntity>> Igen_imagegallarycategoryFacadeObjects.GAPgListView(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().GAPgListView(gen_imagegallarycategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallarycategoryEntity> Igen_imagegallarycategoryFacade.GAPgListViewgen_imagegallarycategory"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_imagegallarycategoryFacadeObjects.GetDataForDropDown(gen_imagegallarycategoryEntity gen_imagegallarycategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallarycategoryDataAccess().GetDataForDropDown(gen_imagegallarycategory,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallarycategoryEntity> Igen_imagegallarycategoryFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}