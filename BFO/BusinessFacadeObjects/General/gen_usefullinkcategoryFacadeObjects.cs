
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
    public sealed partial class gen_usefullinkcategoryFacadeObjects : BaseFacade, Igen_usefullinkcategoryFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_usefullinkcategoryFacadeObjects";
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

        public gen_usefullinkcategoryFacadeObjects()
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

        ~gen_usefullinkcategoryFacadeObjects()
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
		
		async Task<long> Igen_usefullinkcategoryFacadeObjects.Delete(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().Delete(gen_usefullinkcategory, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_usefullinkcategoryFacade.Deletegen_usefullinkcategory"));
            }
        }
		
		async Task<long> Igen_usefullinkcategoryFacadeObjects.Update(gen_usefullinkcategoryEntity gen_usefullinkcategory , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().Update(gen_usefullinkcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_usefullinkcategoryFacade.Updategen_usefullinkcategory"));
            }
		}
		
		async Task<long> Igen_usefullinkcategoryFacadeObjects.Add(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().Add(gen_usefullinkcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_usefullinkcategoryFacade.Addgen_usefullinkcategory"));
            }
		}
		
        async Task<long> Igen_usefullinkcategoryFacadeObjects.SaveList(List<gen_usefullinkcategoryEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_usefullinkcategoryEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_usefullinkcategoryEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_usefullinkcategoryEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_usefullinkcategory"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryFacadeObjects.GetAll(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().GetAll(gen_usefullinkcategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkcategoryEntity> Igen_usefullinkcategoryFacade.GetAllgen_usefullinkcategory"));
            }
		}
		
		async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryFacadeObjects.GetAllByPages(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().GetAllByPages(gen_usefullinkcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkcategoryEntity> Igen_usefullinkcategoryFacade.GetAllByPagesgen_usefullinkcategory"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_usefullinkcategoryFacadeObjects.SaveMasterDetgen_usefullink(gen_usefullinkcategoryEntity Master, List<gen_usefullinkEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_usefullinkEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_usefullinkEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_usefullinkEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().SaveMasterDetgen_usefullink(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_usefullink"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_usefullinkcategoryEntity>  Igen_usefullinkcategoryFacadeObjects.GetSingle(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().GetSingle(gen_usefullinkcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_usefullinkcategoryEntity Igen_usefullinkcategoryFacade.GetSinglegen_usefullinkcategory"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_usefullinkcategoryEntity>> Igen_usefullinkcategoryFacadeObjects.GAPgListView(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().GAPgListView(gen_usefullinkcategory,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkcategoryEntity> Igen_usefullinkcategoryFacade.GAPgListViewgen_usefullinkcategory"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_usefullinkcategoryFacadeObjects.GetDataForDropDown(gen_usefullinkcategoryEntity gen_usefullinkcategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkcategoryDataAccess().GetDataForDropDown(gen_usefullinkcategory,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkcategoryEntity> Igen_usefullinkcategoryFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}