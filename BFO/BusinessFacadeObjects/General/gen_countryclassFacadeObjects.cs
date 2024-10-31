
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
    public sealed partial class gen_countryclassFacadeObjects : BaseFacade, Igen_countryclassFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_countryclassFacadeObjects";
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

        public gen_countryclassFacadeObjects()
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

        ~gen_countryclassFacadeObjects()
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
		
		async Task<long> Igen_countryclassFacadeObjects.Delete(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_countryclassDataAccess().Delete(gen_countryclass, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countryclassFacade.Deletegen_countryclass"));
            }
        }
		
		async Task<long> Igen_countryclassFacadeObjects.Update(gen_countryclassEntity gen_countryclass , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().Update(gen_countryclass,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_countryclassFacade.Updategen_countryclass"));
            }
		}
		
		async Task<long> Igen_countryclassFacadeObjects.Add(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().Add(gen_countryclass, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_countryclassFacade.Addgen_countryclass"));
            }
		}
		
        async Task<long> Igen_countryclassFacadeObjects.SaveList(List<gen_countryclassEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_countryclassEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_countryclassEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_countryclassEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_countryclassDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_countryclass"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_countryclassEntity>> Igen_countryclassFacadeObjects.GetAll(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().GetAll(gen_countryclass, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryclassEntity> Igen_countryclassFacade.GetAllgen_countryclass"));
            }
		}
		
		async Task<IList<gen_countryclassEntity>> Igen_countryclassFacadeObjects.GetAllByPages(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().GetAllByPages(gen_countryclass,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryclassEntity> Igen_countryclassFacade.GetAllByPagesgen_countryclass"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_countryclassFacadeObjects.SaveMasterDetreg_familly(gen_countryclassEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_famillyEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_famillyEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_famillyEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_countryclassDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_countryclassEntity>  Igen_countryclassFacadeObjects.GetSingle(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().GetSingle(gen_countryclass,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_countryclassEntity Igen_countryclassFacade.GetSinglegen_countryclass"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_countryclassEntity>> Igen_countryclassFacadeObjects.GAPgListView(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().GAPgListView(gen_countryclass,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_countryclassEntity> Igen_countryclassFacade.GAPgListViewgen_countryclass"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_countryclassFacadeObjects.GetDataForDropDown(gen_countryclassEntity gen_countryclass, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_countryclassDataAccess().GetDataForDropDown(gen_countryclass,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_countryclassEntity> Igen_countryclassFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}