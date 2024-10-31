
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
    public sealed partial class gen_newsgalleryFacadeObjects : BaseFacade, Igen_newsgalleryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_newsgalleryFacadeObjects";
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

        public gen_newsgalleryFacadeObjects()
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

        ~gen_newsgalleryFacadeObjects()
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
		
		async Task<long> Igen_newsgalleryFacadeObjects.Delete(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().Delete(gen_newsgallery, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newsgalleryFacade.Deletegen_newsgallery"));
            }
        }
		
		async Task<long> Igen_newsgalleryFacadeObjects.Update(gen_newsgalleryEntity gen_newsgallery , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().Update(gen_newsgallery,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_newsgalleryFacade.Updategen_newsgallery"));
            }
		}
		
		async Task<long> Igen_newsgalleryFacadeObjects.Add(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().Add(gen_newsgallery, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newsgalleryFacade.Addgen_newsgallery"));
            }
		}
		
        async Task<long> Igen_newsgalleryFacadeObjects.SaveList(List<gen_newsgalleryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_newsgalleryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_newsgalleryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_newsgalleryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_newsgalleryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_newsgallery"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_newsgalleryEntity>> Igen_newsgalleryFacadeObjects.GetAll(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().GetAll(gen_newsgallery, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsgalleryEntity> Igen_newsgalleryFacade.GetAllgen_newsgallery"));
            }
		}
		
		async Task<IList<gen_newsgalleryEntity>> Igen_newsgalleryFacadeObjects.GetAllByPages(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().GetAllByPages(gen_newsgallery,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsgalleryEntity> Igen_newsgalleryFacade.GetAllByPagesgen_newsgallery"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_newsgalleryEntity>  Igen_newsgalleryFacadeObjects.GetSingle(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().GetSingle(gen_newsgallery,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_newsgalleryEntity Igen_newsgalleryFacade.GetSinglegen_newsgallery"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_newsgalleryEntity>> Igen_newsgalleryFacadeObjects.GAPgListView(gen_newsgalleryEntity gen_newsgallery, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsgalleryDataAccess().GAPgListView(gen_newsgallery,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsgalleryEntity> Igen_newsgalleryFacade.GAPgListViewgen_newsgallery"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}
