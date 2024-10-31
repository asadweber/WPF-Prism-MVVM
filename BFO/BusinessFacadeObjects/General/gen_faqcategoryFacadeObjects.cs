
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
    public sealed partial class gen_faqcategoryFacadeObjects : BaseFacade, Igen_faqcategoryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_faqcategoryFacadeObjects";
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

        public gen_faqcategoryFacadeObjects()
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

        ~gen_faqcategoryFacadeObjects()
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
		
		async Task<long> Igen_faqcategoryFacadeObjects.Delete(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().Delete(gen_faqcategory, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_faqcategoryFacade.Deletegen_faqcategory"));
            }
        }
		
		async Task<long> Igen_faqcategoryFacadeObjects.Update(gen_faqcategoryEntity gen_faqcategory , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().Update(gen_faqcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_faqcategoryFacade.Updategen_faqcategory"));
            }
		}
		
		async Task<long> Igen_faqcategoryFacadeObjects.Add(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().Add(gen_faqcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_faqcategoryFacade.Addgen_faqcategory"));
            }
		}
		
        async Task<long> Igen_faqcategoryFacadeObjects.SaveList(List<gen_faqcategoryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_faqcategoryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_faqcategoryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_faqcategoryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_faqcategoryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_faqcategory"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryFacadeObjects.GetAll(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().GetAll(gen_faqcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqcategoryEntity> Igen_faqcategoryFacade.GetAllgen_faqcategory"));
            }
		}
		
		async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryFacadeObjects.GetAllByPages(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().GetAllByPages(gen_faqcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqcategoryEntity> Igen_faqcategoryFacade.GetAllByPagesgen_faqcategory"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_faqcategoryFacadeObjects.SaveMasterDetgen_faq(gen_faqcategoryEntity Master, List<gen_faqEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_faqEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_faqEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_faqEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_faqcategoryDataAccess().SaveMasterDetgen_faq(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_faq"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_faqcategoryEntity>  Igen_faqcategoryFacadeObjects.GetSingle(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().GetSingle(gen_faqcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_faqcategoryEntity Igen_faqcategoryFacade.GetSinglegen_faqcategory"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_faqcategoryEntity>> Igen_faqcategoryFacadeObjects.GAPgListView(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().GAPgListView(gen_faqcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqcategoryEntity> Igen_faqcategoryFacade.GAPgListViewgen_faqcategory"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_faqcategoryFacadeObjects.GetDataForDropDown(gen_faqcategoryEntity gen_faqcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqcategoryDataAccess().GetDataForDropDown(gen_faqcategory,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_faqcategoryEntity> Igen_faqcategoryFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}