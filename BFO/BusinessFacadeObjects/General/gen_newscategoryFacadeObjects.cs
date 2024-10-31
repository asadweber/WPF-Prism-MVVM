
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
    public sealed partial class gen_newscategoryFacadeObjects : BaseFacade, Igen_newscategoryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_newscategoryFacadeObjects";
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

        public gen_newscategoryFacadeObjects()
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

        ~gen_newscategoryFacadeObjects()
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
		
		async Task<long> Igen_newscategoryFacadeObjects.Delete(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_newscategoryDataAccess().Delete(gen_newscategory, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newscategoryFacade.Deletegen_newscategory"));
            }
        }
		
		async Task<long> Igen_newscategoryFacadeObjects.Update(gen_newscategoryEntity gen_newscategory , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().Update(gen_newscategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_newscategoryFacade.Updategen_newscategory"));
            }
		}
		
		async Task<long> Igen_newscategoryFacadeObjects.Add(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().Add(gen_newscategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newscategoryFacade.Addgen_newscategory"));
            }
		}
		
        async Task<long> Igen_newscategoryFacadeObjects.SaveList(List<gen_newscategoryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_newscategoryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_newscategoryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_newscategoryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_newscategoryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_newscategory"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_newscategoryEntity>> Igen_newscategoryFacadeObjects.GetAll(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().GetAll(gen_newscategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newscategoryEntity> Igen_newscategoryFacade.GetAllgen_newscategory"));
            }
		}
		
		async Task<IList<gen_newscategoryEntity>> Igen_newscategoryFacadeObjects.GetAllByPages(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().GetAllByPages(gen_newscategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newscategoryEntity> Igen_newscategoryFacade.GetAllByPagesgen_newscategory"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_newscategoryFacadeObjects.SaveMasterDetgen_news(gen_newscategoryEntity Master, List<gen_newsEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_newsEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_newsEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_newsEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_newscategoryDataAccess().SaveMasterDetgen_news(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_news"));
               }
        }
        
        
        async Task<long> Igen_newscategoryFacadeObjects.SaveMasterDetgen_newscategory(gen_newscategoryEntity Master, List<gen_newscategoryEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_newscategoryEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_newscategoryEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_newscategoryEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_newscategoryDataAccess().SaveMasterDetgen_newscategory(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_newscategory"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_newscategoryEntity>  Igen_newscategoryFacadeObjects.GetSingle(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().GetSingle(gen_newscategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_newscategoryEntity Igen_newscategoryFacade.GetSinglegen_newscategory"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_newscategoryEntity>> Igen_newscategoryFacadeObjects.GAPgListView(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().GAPgListView(gen_newscategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newscategoryEntity> Igen_newscategoryFacade.GAPgListViewgen_newscategory"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_newscategoryFacadeObjects.GetDataForDropDown(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().GetDataForDropDown(gen_newscategory,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_newscategoryEntity> Igen_newscategoryFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}