
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
    public sealed partial class gen_batchcandidatereqfileFacadeObjects : BaseFacade, Igen_batchcandidatereqfileFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_batchcandidatereqfileFacadeObjects";
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

        public gen_batchcandidatereqfileFacadeObjects()
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

        ~gen_batchcandidatereqfileFacadeObjects()
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
		
		async Task<long> Igen_batchcandidatereqfileFacadeObjects.Delete(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().Delete(gen_batchcandidatereqfile, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatereqfileFacade.Deletegen_batchcandidatereqfile"));
            }
        }
		
		async Task<long> Igen_batchcandidatereqfileFacadeObjects.Update(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().Update(gen_batchcandidatereqfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatereqfileFacade.Updategen_batchcandidatereqfile"));
            }
		}
		
		async Task<long> Igen_batchcandidatereqfileFacadeObjects.Add(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().Add(gen_batchcandidatereqfile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatereqfileFacade.Addgen_batchcandidatereqfile"));
            }
		}
		
        async Task<long> Igen_batchcandidatereqfileFacadeObjects.SaveList(List<gen_batchcandidatereqfileEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_batchcandidatereqfileEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_batchcandidatereqfileEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_batchcandidatereqfileEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_batchcandidatereqfile"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileFacadeObjects.GetAll(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GetAll(gen_batchcandidatereqfile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileFacade.GetAllgen_batchcandidatereqfile"));
            }
		}
		
		async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileFacadeObjects.GetAllByPages(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GetAllByPages(gen_batchcandidatereqfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileFacade.GetAllByPagesgen_batchcandidatereqfile"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_batchcandidatereqfileEntity>  Igen_batchcandidatereqfileFacadeObjects.GetSingle(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GetSingle(gen_batchcandidatereqfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandidatereqfileEntity Igen_batchcandidatereqfileFacade.GetSinglegen_batchcandidatereqfile"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_batchcandidatereqfileEntity>> Igen_batchcandidatereqfileFacadeObjects.GAPgListView(gen_batchcandidatereqfileEntity gen_batchcandidatereqfile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatereqfileDataAccess().GAPgListView(gen_batchcandidatereqfile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatereqfileEntity> Igen_batchcandidatereqfileFacade.GAPgListViewgen_batchcandidatereqfile"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}