
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
    public sealed partial class gen_batchunitlistFacadeObjects : BaseFacade, Igen_batchunitlistFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_batchunitlistFacadeObjects";
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

        public gen_batchunitlistFacadeObjects()
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

        ~gen_batchunitlistFacadeObjects()
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
		
		async Task<long> Igen_batchunitlistFacadeObjects.Delete(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().Delete(gen_batchunitlist, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchunitlistFacade.Deletegen_batchunitlist"));
            }
        }
		
		async Task<long> Igen_batchunitlistFacadeObjects.Update(gen_batchunitlistEntity gen_batchunitlist , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().Update(gen_batchunitlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_batchunitlistFacade.Updategen_batchunitlist"));
            }
		}
		
		async Task<long> Igen_batchunitlistFacadeObjects.Add(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().Add(gen_batchunitlist, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchunitlistFacade.Addgen_batchunitlist"));
            }
		}
		
        async Task<long> Igen_batchunitlistFacadeObjects.SaveList(List<gen_batchunitlistEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_batchunitlistEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_batchunitlistEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_batchunitlistEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_batchunitlistDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_batchunitlist"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistFacadeObjects.GetAll(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().GetAll(gen_batchunitlist, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchunitlistEntity> Igen_batchunitlistFacade.GetAllgen_batchunitlist"));
            }
		}
		
		async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistFacadeObjects.GetAllByPages(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().GetAllByPages(gen_batchunitlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchunitlistEntity> Igen_batchunitlistFacade.GetAllByPagesgen_batchunitlist"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_batchunitlistEntity>  Igen_batchunitlistFacadeObjects.GetSingle(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().GetSingle(gen_batchunitlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchunitlistEntity Igen_batchunitlistFacade.GetSinglegen_batchunitlist"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_batchunitlistEntity>> Igen_batchunitlistFacadeObjects.GAPgListView(gen_batchunitlistEntity gen_batchunitlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchunitlistDataAccess().GAPgListView(gen_batchunitlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchunitlistEntity> Igen_batchunitlistFacade.GAPgListViewgen_batchunitlist"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}