
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
    public sealed partial class gen_imagegallaryFacadeObjects : BaseFacade, Igen_imagegallaryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_imagegallaryFacadeObjects";
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

        public gen_imagegallaryFacadeObjects()
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

        ~gen_imagegallaryFacadeObjects()
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
		
		async Task<long> Igen_imagegallaryFacadeObjects.Delete(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().Delete(gen_imagegallary, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_imagegallaryFacade.Deletegen_imagegallary"));
            }
        }
		
		async Task<long> Igen_imagegallaryFacadeObjects.Update(gen_imagegallaryEntity gen_imagegallary , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().Update(gen_imagegallary,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_imagegallaryFacade.Updategen_imagegallary"));
            }
		}
		
		async Task<long> Igen_imagegallaryFacadeObjects.Add(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().Add(gen_imagegallary, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_imagegallaryFacade.Addgen_imagegallary"));
            }
		}
		
        async Task<long> Igen_imagegallaryFacadeObjects.SaveList(List<gen_imagegallaryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_imagegallaryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_imagegallaryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_imagegallaryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_imagegallaryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_imagegallary"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryFacadeObjects.GetAll(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().GetAll(gen_imagegallary, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallaryEntity> Igen_imagegallaryFacade.GetAllgen_imagegallary"));
            }
		}
		
		async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryFacadeObjects.GetAllByPages(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().GetAllByPages(gen_imagegallary,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallaryEntity> Igen_imagegallaryFacade.GetAllByPagesgen_imagegallary"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_imagegallaryEntity>  Igen_imagegallaryFacadeObjects.GetSingle(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().GetSingle(gen_imagegallary,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_imagegallaryEntity Igen_imagegallaryFacade.GetSinglegen_imagegallary"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_imagegallaryEntity>> Igen_imagegallaryFacadeObjects.GAPgListView(gen_imagegallaryEntity gen_imagegallary, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_imagegallaryDataAccess().GAPgListView(gen_imagegallary,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_imagegallaryEntity> Igen_imagegallaryFacade.GAPgListViewgen_imagegallary"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}