
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
    public sealed partial class gen_servicesFacadeObjects : BaseFacade, Igen_servicesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_servicesFacadeObjects";
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

        public gen_servicesFacadeObjects()
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

        ~gen_servicesFacadeObjects()
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
		
		async Task<long> Igen_servicesFacadeObjects.Delete(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_servicesDataAccess().Delete(gen_services, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicesFacade.Deletegen_services"));
            }
        }
		
		async Task<long> Igen_servicesFacadeObjects.Update(gen_servicesEntity gen_services , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().Update(gen_services,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_servicesFacade.Updategen_services"));
            }
		}
		
		async Task<long> Igen_servicesFacadeObjects.Add(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().Add(gen_services, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicesFacade.Addgen_services"));
            }
		}
		
        async Task<long> Igen_servicesFacadeObjects.SaveList(List<gen_servicesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_servicesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_servicesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_servicesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_servicesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_services"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_servicesEntity>> Igen_servicesFacadeObjects.GetAll(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().GetAll(gen_services, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicesEntity> Igen_servicesFacade.GetAllgen_services"));
            }
		}
		
		async Task<IList<gen_servicesEntity>> Igen_servicesFacadeObjects.GetAllByPages(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().GetAllByPages(gen_services,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicesEntity> Igen_servicesFacade.GetAllByPagesgen_services"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_servicesEntity>  Igen_servicesFacadeObjects.GetSingle(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().GetSingle(gen_services,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_servicesEntity Igen_servicesFacade.GetSinglegen_services"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_servicesEntity>> Igen_servicesFacadeObjects.GAPgListView(gen_servicesEntity gen_services, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicesDataAccess().GAPgListView(gen_services,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicesEntity> Igen_servicesFacade.GAPgListViewgen_services"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}