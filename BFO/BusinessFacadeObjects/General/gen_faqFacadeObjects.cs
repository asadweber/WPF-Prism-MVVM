
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
    public sealed partial class gen_faqFacadeObjects : BaseFacade, Igen_faqFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_faqFacadeObjects";
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

        public gen_faqFacadeObjects()
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

        ~gen_faqFacadeObjects()
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
		
		async Task<long> Igen_faqFacadeObjects.Delete(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_faqDataAccess().Delete(gen_faq, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_faqFacade.Deletegen_faq"));
            }
        }
		
		async Task<long> Igen_faqFacadeObjects.Update(gen_faqEntity gen_faq , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().Update(gen_faq,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_faqFacade.Updategen_faq"));
            }
		}
		
		async Task<long> Igen_faqFacadeObjects.Add(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().Add(gen_faq, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_faqFacade.Addgen_faq"));
            }
		}
		
        async Task<long> Igen_faqFacadeObjects.SaveList(List<gen_faqEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_faqEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_faqEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_faqEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_faqDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_faq"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_faqEntity>> Igen_faqFacadeObjects.GetAll(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().GetAll(gen_faq, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqEntity> Igen_faqFacade.GetAllgen_faq"));
            }
		}
		
		async Task<IList<gen_faqEntity>> Igen_faqFacadeObjects.GetAllByPages(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().GetAllByPages(gen_faq,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqEntity> Igen_faqFacade.GetAllByPagesgen_faq"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_faqEntity>  Igen_faqFacadeObjects.GetSingle(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().GetSingle(gen_faq,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_faqEntity Igen_faqFacade.GetSinglegen_faq"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_faqEntity>> Igen_faqFacadeObjects.GAPgListView(gen_faqEntity gen_faq, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_faqDataAccess().GAPgListView(gen_faq,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_faqEntity> Igen_faqFacade.GAPgListViewgen_faq"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}