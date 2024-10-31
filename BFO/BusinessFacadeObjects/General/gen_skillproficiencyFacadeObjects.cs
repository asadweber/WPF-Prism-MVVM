
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
    public sealed partial class gen_skillproficiencyFacadeObjects : BaseFacade, Igen_skillproficiencyFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_skillproficiencyFacadeObjects";
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

        public gen_skillproficiencyFacadeObjects()
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

        ~gen_skillproficiencyFacadeObjects()
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
		
		async Task<long> Igen_skillproficiencyFacadeObjects.Delete(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().Delete(gen_skillproficiency, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_skillproficiencyFacade.Deletegen_skillproficiency"));
            }
        }
		
		async Task<long> Igen_skillproficiencyFacadeObjects.Update(gen_skillproficiencyEntity gen_skillproficiency , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().Update(gen_skillproficiency,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_skillproficiencyFacade.Updategen_skillproficiency"));
            }
		}
		
		async Task<long> Igen_skillproficiencyFacadeObjects.Add(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().Add(gen_skillproficiency, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_skillproficiencyFacade.Addgen_skillproficiency"));
            }
		}
		
        async Task<long> Igen_skillproficiencyFacadeObjects.SaveList(List<gen_skillproficiencyEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_skillproficiencyEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_skillproficiencyEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_skillproficiencyEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_skillproficiencyDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_skillproficiency"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyFacadeObjects.GetAll(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().GetAll(gen_skillproficiency, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_skillproficiencyEntity> Igen_skillproficiencyFacade.GetAllgen_skillproficiency"));
            }
		}
		
		async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyFacadeObjects.GetAllByPages(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().GetAllByPages(gen_skillproficiency,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_skillproficiencyEntity> Igen_skillproficiencyFacade.GetAllByPagesgen_skillproficiency"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_skillproficiencyFacadeObjects.SaveMasterDetreg_language(gen_skillproficiencyEntity Master, List<reg_languageEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_skillproficiencyDataAccess().SaveMasterDetreg_language(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_language"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_skillproficiencyEntity>  Igen_skillproficiencyFacadeObjects.GetSingle(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().GetSingle(gen_skillproficiency,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_skillproficiencyEntity Igen_skillproficiencyFacade.GetSinglegen_skillproficiency"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_skillproficiencyEntity>> Igen_skillproficiencyFacadeObjects.GAPgListView(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().GAPgListView(gen_skillproficiency,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_skillproficiencyEntity> Igen_skillproficiencyFacade.GAPgListViewgen_skillproficiency"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_skillproficiencyFacadeObjects.GetDataForDropDown(gen_skillproficiencyEntity gen_skillproficiency, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_skillproficiencyDataAccess().GetDataForDropDown(gen_skillproficiency,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_skillproficiencyEntity> Igen_skillproficiencyFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}