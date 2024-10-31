
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
    public sealed partial class gen_generallookFacadeObjects : BaseFacade, Igen_generallookFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_generallookFacadeObjects";
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

        public gen_generallookFacadeObjects()
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

        ~gen_generallookFacadeObjects()
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
		
		async Task<long> Igen_generallookFacadeObjects.Delete(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_generallookDataAccess().Delete(gen_generallook, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_generallookFacade.Deletegen_generallook"));
            }
        }
		
		async Task<long> Igen_generallookFacadeObjects.Update(gen_generallookEntity gen_generallook , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().Update(gen_generallook,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_generallookFacade.Updategen_generallook"));
            }
		}
		
		async Task<long> Igen_generallookFacadeObjects.Add(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().Add(gen_generallook, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_generallookFacade.Addgen_generallook"));
            }
		}
		
        async Task<long> Igen_generallookFacadeObjects.SaveList(List<gen_generallookEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_generallookEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_generallookEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_generallookEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_generallookDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_generallook"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_generallookEntity>> Igen_generallookFacadeObjects.GetAll(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().GetAll(gen_generallook, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generallookEntity> Igen_generallookFacade.GetAllgen_generallook"));
            }
		}
		
		async Task<IList<gen_generallookEntity>> Igen_generallookFacadeObjects.GetAllByPages(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().GetAllByPages(gen_generallook,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generallookEntity> Igen_generallookFacade.GetAllByPagesgen_generallook"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_generallookEntity>  Igen_generallookFacadeObjects.GetSingle(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().GetSingle(gen_generallook,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_generallookEntity Igen_generallookFacade.GetSinglegen_generallook"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_generallookEntity>> Igen_generallookFacadeObjects.GAPgListView(gen_generallookEntity gen_generallook, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generallookDataAccess().GAPgListView(gen_generallook,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generallookEntity> Igen_generallookFacade.GAPgListViewgen_generallook"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}