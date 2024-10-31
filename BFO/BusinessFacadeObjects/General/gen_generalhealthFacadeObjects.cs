
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
    public sealed partial class gen_generalhealthFacadeObjects : BaseFacade, Igen_generalhealthFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_generalhealthFacadeObjects";
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

        public gen_generalhealthFacadeObjects()
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

        ~gen_generalhealthFacadeObjects()
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
		
		async Task<long> Igen_generalhealthFacadeObjects.Delete(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_generalhealthDataAccess().Delete(gen_generalhealth, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_generalhealthFacade.Deletegen_generalhealth"));
            }
        }
		
		async Task<long> Igen_generalhealthFacadeObjects.Update(gen_generalhealthEntity gen_generalhealth , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().Update(gen_generalhealth,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_generalhealthFacade.Updategen_generalhealth"));
            }
		}
		
		async Task<long> Igen_generalhealthFacadeObjects.Add(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().Add(gen_generalhealth, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_generalhealthFacade.Addgen_generalhealth"));
            }
		}
		
        async Task<long> Igen_generalhealthFacadeObjects.SaveList(List<gen_generalhealthEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_generalhealthEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_generalhealthEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_generalhealthEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_generalhealthDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_generalhealth"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_generalhealthEntity>> Igen_generalhealthFacadeObjects.GetAll(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().GetAll(gen_generalhealth, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generalhealthEntity> Igen_generalhealthFacade.GetAllgen_generalhealth"));
            }
		}
		
		async Task<IList<gen_generalhealthEntity>> Igen_generalhealthFacadeObjects.GetAllByPages(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().GetAllByPages(gen_generalhealth,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generalhealthEntity> Igen_generalhealthFacade.GetAllByPagesgen_generalhealth"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_generalhealthEntity>  Igen_generalhealthFacadeObjects.GetSingle(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().GetSingle(gen_generalhealth,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_generalhealthEntity Igen_generalhealthFacade.GetSinglegen_generalhealth"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_generalhealthEntity>> Igen_generalhealthFacadeObjects.GAPgListView(gen_generalhealthEntity gen_generalhealth, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_generalhealthDataAccess().GAPgListView(gen_generalhealth,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_generalhealthEntity> Igen_generalhealthFacade.GAPgListViewgen_generalhealth"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}