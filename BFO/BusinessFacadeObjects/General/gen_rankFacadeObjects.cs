
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
    public sealed partial class gen_rankFacadeObjects : BaseFacade, Igen_rankFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_rankFacadeObjects";
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

        public gen_rankFacadeObjects()
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

        ~gen_rankFacadeObjects()
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
		
		async Task<long> Igen_rankFacadeObjects.Delete(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_rankDataAccess().Delete(gen_rank, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Deletegen_rank"));
            }
        }
		
		async Task<long> Igen_rankFacadeObjects.Update(gen_rankEntity gen_rank , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().Update(gen_rank,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Updategen_rank"));
            }
		}
		
		async Task<long> Igen_rankFacadeObjects.Add(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().Add(gen_rank, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_rankFacade.Addgen_rank"));
            }
		}
		
        async Task<long> Igen_rankFacadeObjects.SaveList(List<gen_rankEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_rankEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_rankEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_rankEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_rankDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_rank"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_rankEntity>> Igen_rankFacadeObjects.GetAll(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().GetAll(gen_rank, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GetAllgen_rank"));
            }
		}
		
		async Task<IList<gen_rankEntity>> Igen_rankFacadeObjects.GetAllByPages(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().GetAllByPages(gen_rank,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GetAllByPagesgen_rank"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_rankEntity>  Igen_rankFacadeObjects.GetSingle(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().GetSingle(gen_rank,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_rankEntity Igen_rankFacade.GetSinglegen_rank"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_rankEntity>> Igen_rankFacadeObjects.GAPgListView(gen_rankEntity gen_rank, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_rankDataAccess().GAPgListView(gen_rank,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_rankEntity> Igen_rankFacade.GAPgListViewgen_rank"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}