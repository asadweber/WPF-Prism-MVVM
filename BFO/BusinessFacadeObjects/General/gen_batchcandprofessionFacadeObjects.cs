
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
    public sealed partial class gen_batchcandprofessionFacadeObjects : BaseFacade, Igen_batchcandprofessionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_batchcandprofessionFacadeObjects";
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

        public gen_batchcandprofessionFacadeObjects()
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

        ~gen_batchcandprofessionFacadeObjects()
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
		
		async Task<long> Igen_batchcandprofessionFacadeObjects.Delete(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().Delete(gen_batchcandprofession, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandprofessionFacade.Deletegen_batchcandprofession"));
            }
        }
		
		async Task<long> Igen_batchcandprofessionFacadeObjects.Update(gen_batchcandprofessionEntity gen_batchcandprofession , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().Update(gen_batchcandprofession,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_batchcandprofessionFacade.Updategen_batchcandprofession"));
            }
		}
		
		async Task<long> Igen_batchcandprofessionFacadeObjects.Add(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().Add(gen_batchcandprofession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandprofessionFacade.Addgen_batchcandprofession"));
            }
		}
		
        async Task<long> Igen_batchcandprofessionFacadeObjects.SaveList(List<gen_batchcandprofessionEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_batchcandprofessionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_batchcandprofessionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_batchcandprofessionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_batchcandprofession"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionFacadeObjects.GetAll(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GetAll(gen_batchcandprofession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacade.GetAllgen_batchcandprofession"));
            }
		}
		
		async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionFacadeObjects.GetAllByPages(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GetAllByPages(gen_batchcandprofession,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacade.GetAllByPagesgen_batchcandprofession"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_batchcandprofessionEntity>  Igen_batchcandprofessionFacadeObjects.GetSingle(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GetSingle(gen_batchcandprofession,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandprofessionEntity Igen_batchcandprofessionFacade.GetSinglegen_batchcandprofession"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_batchcandprofessionEntity>> Igen_batchcandprofessionFacadeObjects.GAPgListView(gen_batchcandprofessionEntity gen_batchcandprofession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandprofessionDataAccess().GAPgListView(gen_batchcandprofession,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandprofessionEntity> Igen_batchcandprofessionFacade.GAPgListViewgen_batchcandprofession"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}