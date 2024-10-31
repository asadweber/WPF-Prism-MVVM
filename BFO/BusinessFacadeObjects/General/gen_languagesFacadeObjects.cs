
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
    public sealed partial class gen_languagesFacadeObjects : BaseFacade, Igen_languagesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_languagesFacadeObjects";
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

        public gen_languagesFacadeObjects()
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

        ~gen_languagesFacadeObjects()
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
		
		async Task<long> Igen_languagesFacadeObjects.Delete(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_languagesDataAccess().Delete(gen_languages, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languagesFacade.Deletegen_languages"));
            }
        }
		
		async Task<long> Igen_languagesFacadeObjects.Update(gen_languagesEntity gen_languages , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().Update(gen_languages,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_languagesFacade.Updategen_languages"));
            }
		}
		
		async Task<long> Igen_languagesFacadeObjects.Add(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().Add(gen_languages, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languagesFacade.Addgen_languages"));
            }
		}
		
        async Task<long> Igen_languagesFacadeObjects.SaveList(List<gen_languagesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_languagesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_languagesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_languagesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_languagesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_languages"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_languagesEntity>> Igen_languagesFacadeObjects.GetAll(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().GetAll(gen_languages, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languagesEntity> Igen_languagesFacade.GetAllgen_languages"));
            }
		}
		
		async Task<IList<gen_languagesEntity>> Igen_languagesFacadeObjects.GetAllByPages(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().GetAllByPages(gen_languages,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languagesEntity> Igen_languagesFacade.GetAllByPagesgen_languages"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_languagesFacadeObjects.SaveMasterDetreg_language(gen_languagesEntity Master, List<reg_languageEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_languageEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_languageEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_languageEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_languagesDataAccess().SaveMasterDetreg_language(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_language"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_languagesEntity>  Igen_languagesFacadeObjects.GetSingle(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().GetSingle(gen_languages,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_languagesEntity Igen_languagesFacade.GetSinglegen_languages"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_languagesEntity>> Igen_languagesFacadeObjects.GAPgListView(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().GAPgListView(gen_languages,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languagesEntity> Igen_languagesFacade.GAPgListViewgen_languages"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_languagesFacadeObjects.GetDataForDropDown(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().GetDataForDropDown(gen_languages,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_languagesEntity> Igen_languagesFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}