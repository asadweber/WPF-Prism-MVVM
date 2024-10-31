
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
    public sealed partial class gen_certificatesubjectsFacadeObjects : BaseFacade, Igen_certificatesubjectsFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_certificatesubjectsFacadeObjects";
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

        public gen_certificatesubjectsFacadeObjects()
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

        ~gen_certificatesubjectsFacadeObjects()
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
		
		async Task<long> Igen_certificatesubjectsFacadeObjects.Delete(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().Delete(gen_certificatesubjects, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatesubjectsFacade.Deletegen_certificatesubjects"));
            }
        }
		
		async Task<long> Igen_certificatesubjectsFacadeObjects.Update(gen_certificatesubjectsEntity gen_certificatesubjects , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().Update(gen_certificatesubjects,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_certificatesubjectsFacade.Updategen_certificatesubjects"));
            }
		}
		
		async Task<long> Igen_certificatesubjectsFacadeObjects.Add(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().Add(gen_certificatesubjects, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatesubjectsFacade.Addgen_certificatesubjects"));
            }
		}
		
        async Task<long> Igen_certificatesubjectsFacadeObjects.SaveList(List<gen_certificatesubjectsEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_certificatesubjectsEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_certificatesubjectsEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_certificatesubjectsEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_certificatesubjects"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsFacadeObjects.GetAll(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GetAll(gen_certificatesubjects, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatesubjectsEntity> Igen_certificatesubjectsFacade.GetAllgen_certificatesubjects"));
            }
		}
		
		async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsFacadeObjects.GetAllByPages(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GetAllByPages(gen_certificatesubjects,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatesubjectsEntity> Igen_certificatesubjectsFacade.GetAllByPagesgen_certificatesubjects"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_certificatesubjectsEntity>  Igen_certificatesubjectsFacadeObjects.GetSingle(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GetSingle(gen_certificatesubjects,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_certificatesubjectsEntity Igen_certificatesubjectsFacade.GetSinglegen_certificatesubjects"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_certificatesubjectsEntity>> Igen_certificatesubjectsFacadeObjects.GAPgListView(gen_certificatesubjectsEntity gen_certificatesubjects, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatesubjectsDataAccess().GAPgListView(gen_certificatesubjects,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatesubjectsEntity> Igen_certificatesubjectsFacade.GAPgListViewgen_certificatesubjects"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}