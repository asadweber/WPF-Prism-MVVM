
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
    public sealed partial class gen_econtactlistFacadeObjects : BaseFacade, Igen_econtactlistFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_econtactlistFacadeObjects";
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

        public gen_econtactlistFacadeObjects()
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

        ~gen_econtactlistFacadeObjects()
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
		
		async Task<long> Igen_econtactlistFacadeObjects.Delete(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_econtactlistDataAccess().Delete(gen_econtactlist, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_econtactlistFacade.Deletegen_econtactlist"));
            }
        }
		
		async Task<long> Igen_econtactlistFacadeObjects.Update(gen_econtactlistEntity gen_econtactlist , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_econtactlistDataAccess().Update(gen_econtactlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_econtactlistFacade.Updategen_econtactlist"));
            }
		}
		
		async Task<long> Igen_econtactlistFacadeObjects.Add(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_econtactlistDataAccess().Add(gen_econtactlist, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_econtactlistFacade.Addgen_econtactlist"));
            }
		}
		
        async Task<long> Igen_econtactlistFacadeObjects.SaveList(List<gen_econtactlistEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_econtactlistEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_econtactlistEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_econtactlistEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_econtactlistDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_econtactlist"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_econtactlistEntity>> Igen_econtactlistFacadeObjects.GetAll(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_econtactlistDataAccess().GetAll(gen_econtactlist, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_econtactlistEntity> Igen_econtactlistFacade.GetAllgen_econtactlist"));
            }
		}
		
		async Task<IList<gen_econtactlistEntity>> Igen_econtactlistFacadeObjects.GetAllByPages(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_econtactlistDataAccess().GetAllByPages(gen_econtactlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_econtactlistEntity> Igen_econtactlistFacade.GetAllByPagesgen_econtactlist"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_econtactlistEntity>  Igen_econtactlistFacadeObjects.GetSingle(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_econtactlistDataAccess().GetSingle(gen_econtactlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_econtactlistEntity Igen_econtactlistFacade.GetSinglegen_econtactlist"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_econtactlistEntity>> Igen_econtactlistFacadeObjects.GAPgListView(gen_econtactlistEntity gen_econtactlist, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_econtactlistDataAccess().GAPgListView(gen_econtactlist,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_econtactlistEntity> Igen_econtactlistFacade.GAPgListViewgen_econtactlist"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}