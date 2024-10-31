
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
    public sealed partial class gen_newsFacadeObjects : BaseFacade, Igen_newsFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_newsFacadeObjects";
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

        public gen_newsFacadeObjects()
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

        ~gen_newsFacadeObjects()
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
		
		async Task<long> Igen_newsFacadeObjects.Delete(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_newsDataAccess().Delete(gen_news, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.Deletegen_news"));
            }
        }
		
		async Task<long> Igen_newsFacadeObjects.Update(gen_newsEntity gen_news , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().Update(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.Updategen_news"));
            }
		}
		
		async Task<long> Igen_newsFacadeObjects.Add(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().Add(gen_news, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.Addgen_news"));
            }
		}
		
        async Task<long> Igen_newsFacadeObjects.SaveList(List<gen_newsEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_newsEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_newsEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_newsEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_newsDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_news"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_newsEntity>> Igen_newsFacadeObjects.GetAll(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().GetAll(gen_news, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsEntity> Igen_newsFacade.GetAllgen_news"));
            }
		}
		
		async Task<IList<gen_newsEntity>> Igen_newsFacadeObjects.GetAllByPages(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().GetAllByPages(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsEntity> Igen_newsFacade.GetAllByPagesgen_news"));
            }
		}

        #endregion GetAll

        #region FOR Master Details SAVE	

        async Task<long> Igen_newsFacadeObjects.SaveMasterDetgen_newsgallery(gen_newsEntity Master, List<gen_newsgalleryEntity> DetailList, CancellationToken cancellationToken)
        {
            try
            {
                DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                if (Master.CurrentState == BaseEntity.EntityState.Deleted)
                    DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                IList<gen_newsgalleryEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_newsgalleryEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_newsgalleryEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                return await DataAccessFactory.Creategen_newsDataAccess().SaveMasterDetgen_newsgallery(Master, listAdded, listUpdated, listDeleted, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_newscategory"));
            }
        }


        #endregion


        #region Simple load Single Row
        async Task<gen_newsEntity>  Igen_newsFacadeObjects.GetSingle(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().GetSingle(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_newsEntity Igen_newsFacade.GetSinglegen_news"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_newsEntity>> Igen_newsFacadeObjects.GAPgListView(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().GAPgListView(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsEntity> Igen_newsFacade.GAPgListViewgen_news"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        async Task<long> Igen_newsFacadeObjects.UpdatePublished(gen_newsEntity gen_news, CancellationToken cancellationToken )
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().UpdatePublished(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.UpdatePublishedgen_news"));
            }
		}
        async Task<long> Igen_newsFacadeObjects.UpdateReviewed(gen_newsEntity gen_news, CancellationToken cancellationToken )
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().UpdateReviewed(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.UpdateReviewedgen_news"));
            }
		}
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}