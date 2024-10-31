
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
    public sealed partial class gen_educationgradeFacadeObjects : BaseFacade, Igen_educationgradeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_educationgradeFacadeObjects";
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

        public gen_educationgradeFacadeObjects()
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

        ~gen_educationgradeFacadeObjects()
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
		
		async Task<long> Igen_educationgradeFacadeObjects.Delete(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_educationgradeDataAccess().Delete(gen_educationgrade, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationgradeFacade.Deletegen_educationgrade"));
            }
        }
		
		async Task<long> Igen_educationgradeFacadeObjects.Update(gen_educationgradeEntity gen_educationgrade , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().Update(gen_educationgrade,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_educationgradeFacade.Updategen_educationgrade"));
            }
		}
		
		async Task<long> Igen_educationgradeFacadeObjects.Add(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().Add(gen_educationgrade, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationgradeFacade.Addgen_educationgrade"));
            }
		}
		
        async Task<long> Igen_educationgradeFacadeObjects.SaveList(List<gen_educationgradeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_educationgradeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_educationgradeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_educationgradeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_educationgradeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_educationgrade"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_educationgradeEntity>> Igen_educationgradeFacadeObjects.GetAll(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().GetAll(gen_educationgrade, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationgradeEntity> Igen_educationgradeFacade.GetAllgen_educationgrade"));
            }
		}
		
		async Task<IList<gen_educationgradeEntity>> Igen_educationgradeFacadeObjects.GetAllByPages(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().GetAllByPages(gen_educationgrade,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationgradeEntity> Igen_educationgradeFacade.GetAllByPagesgen_educationgrade"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_educationgradeFacadeObjects.SaveMasterDetreg_educationinfo(gen_educationgradeEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_educationinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_educationinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_educationinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_educationgradeDataAccess().SaveMasterDetreg_educationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_educationinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_educationgradeEntity>  Igen_educationgradeFacadeObjects.GetSingle(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().GetSingle(gen_educationgrade,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_educationgradeEntity Igen_educationgradeFacade.GetSinglegen_educationgrade"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeFacadeObjects.GAPgListView(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().GAPgListView(gen_educationgrade,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationgradeEntity> Igen_educationgradeFacade.GAPgListViewgen_educationgrade"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_educationgradeFacadeObjects.GetDataForDropDown(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().GetDataForDropDown(gen_educationgrade,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_educationgradeEntity> Igen_educationgradeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}