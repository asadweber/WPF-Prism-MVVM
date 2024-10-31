
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
    public sealed partial class gen_serviceinfoFacadeObjects : BaseFacade, Igen_serviceinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_serviceinfoFacadeObjects";
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

        public gen_serviceinfoFacadeObjects()
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

        ~gen_serviceinfoFacadeObjects()
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
		
		async Task<long> Igen_serviceinfoFacadeObjects.Delete(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().Delete(gen_serviceinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_serviceinfoFacade.Deletegen_serviceinfo"));
            }
        }
		
		async Task<long> Igen_serviceinfoFacadeObjects.Update(gen_serviceinfoEntity gen_serviceinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().Update(gen_serviceinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_serviceinfoFacade.Updategen_serviceinfo"));
            }
		}
		
		async Task<long> Igen_serviceinfoFacadeObjects.Add(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().Add(gen_serviceinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_serviceinfoFacade.Addgen_serviceinfo"));
            }
		}
		
        async Task<long> Igen_serviceinfoFacadeObjects.SaveList(List<gen_serviceinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_serviceinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_serviceinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_serviceinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_serviceinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_serviceinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoFacadeObjects.GetAll(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().GetAll(gen_serviceinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_serviceinfoEntity> Igen_serviceinfoFacade.GetAllgen_serviceinfo"));
            }
		}
		
		async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoFacadeObjects.GetAllByPages(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().GetAllByPages(gen_serviceinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_serviceinfoEntity> Igen_serviceinfoFacade.GetAllByPagesgen_serviceinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_serviceinfoEntity>  Igen_serviceinfoFacadeObjects.GetSingle(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().GetSingle(gen_serviceinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_serviceinfoEntity Igen_serviceinfoFacade.GetSinglegen_serviceinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_serviceinfoEntity>> Igen_serviceinfoFacadeObjects.GAPgListView(gen_serviceinfoEntity gen_serviceinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_serviceinfoDataAccess().GAPgListView(gen_serviceinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_serviceinfoEntity> Igen_serviceinfoFacade.GAPgListViewgen_serviceinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}