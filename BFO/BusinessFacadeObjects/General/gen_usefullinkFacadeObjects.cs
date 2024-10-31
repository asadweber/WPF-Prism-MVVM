
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
    public sealed partial class gen_usefullinkFacadeObjects : BaseFacade, Igen_usefullinkFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_usefullinkFacadeObjects";
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

        public gen_usefullinkFacadeObjects()
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

        ~gen_usefullinkFacadeObjects()
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
		
		async Task<long> Igen_usefullinkFacadeObjects.Delete(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_usefullinkDataAccess().Delete(gen_usefullink, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_usefullinkFacade.Deletegen_usefullink"));
            }
        }
		
		async Task<long> Igen_usefullinkFacadeObjects.Update(gen_usefullinkEntity gen_usefullink , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().Update(gen_usefullink,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_usefullinkFacade.Updategen_usefullink"));
            }
		}
		
		async Task<long> Igen_usefullinkFacadeObjects.Add(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().Add(gen_usefullink, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_usefullinkFacade.Addgen_usefullink"));
            }
		}
		
        async Task<long> Igen_usefullinkFacadeObjects.SaveList(List<gen_usefullinkEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_usefullinkEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_usefullinkEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_usefullinkEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_usefullinkDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_usefullink"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_usefullinkEntity>> Igen_usefullinkFacadeObjects.GetAll(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().GetAll(gen_usefullink, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkEntity> Igen_usefullinkFacade.GetAllgen_usefullink"));
            }
		}
		
		async Task<IList<gen_usefullinkEntity>> Igen_usefullinkFacadeObjects.GetAllByPages(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().GetAllByPages(gen_usefullink,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkEntity> Igen_usefullinkFacade.GetAllByPagesgen_usefullink"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_usefullinkEntity>  Igen_usefullinkFacadeObjects.GetSingle(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().GetSingle(gen_usefullink,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_usefullinkEntity Igen_usefullinkFacade.GetSinglegen_usefullink"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_usefullinkEntity>> Igen_usefullinkFacadeObjects.GAPgListView(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().GAPgListView(gen_usefullink,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkEntity> Igen_usefullinkFacade.GAPgListViewgen_usefullink"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}