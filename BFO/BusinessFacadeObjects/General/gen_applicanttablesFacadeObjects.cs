
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
    public sealed partial class gen_applicanttablesFacadeObjects : BaseFacade, Igen_applicanttablesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_applicanttablesFacadeObjects";
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

        public gen_applicanttablesFacadeObjects()
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

        ~gen_applicanttablesFacadeObjects()
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
		
		async Task<long> Igen_applicanttablesFacadeObjects.Delete(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().Delete(gen_applicanttables, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_applicanttablesFacade.Deletegen_applicanttables"));
            }
        }
		
		async Task<long> Igen_applicanttablesFacadeObjects.Update(gen_applicanttablesEntity gen_applicanttables , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().Update(gen_applicanttables,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_applicanttablesFacade.Updategen_applicanttables"));
            }
		}
		
		async Task<long> Igen_applicanttablesFacadeObjects.Add(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().Add(gen_applicanttables, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_applicanttablesFacade.Addgen_applicanttables"));
            }
		}
		
        async Task<long> Igen_applicanttablesFacadeObjects.SaveList(List<gen_applicanttablesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_applicanttablesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_applicanttablesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_applicanttablesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_applicanttablesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_applicanttables"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_applicanttablesEntity>> Igen_applicanttablesFacadeObjects.GetAll(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().GetAll(gen_applicanttables, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_applicanttablesEntity> Igen_applicanttablesFacade.GetAllgen_applicanttables"));
            }
		}
		
		async Task<IList<gen_applicanttablesEntity>> Igen_applicanttablesFacadeObjects.GetAllByPages(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().GetAllByPages(gen_applicanttables,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_applicanttablesEntity> Igen_applicanttablesFacade.GetAllByPagesgen_applicanttables"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_applicanttablesFacadeObjects.SaveMasterDetreg_datachecked(gen_applicanttablesEntity Master, List<reg_datacheckedEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_datacheckedEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_datacheckedEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_datacheckedEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_applicanttablesDataAccess().SaveMasterDetreg_datachecked(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_datachecked"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_applicanttablesEntity>  Igen_applicanttablesFacadeObjects.GetSingle(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().GetSingle(gen_applicanttables,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_applicanttablesEntity Igen_applicanttablesFacade.GetSinglegen_applicanttables"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_applicanttablesEntity>> Igen_applicanttablesFacadeObjects.GAPgListView(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().GAPgListView(gen_applicanttables,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_applicanttablesEntity> Igen_applicanttablesFacade.GAPgListViewgen_applicanttables"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_applicanttablesFacadeObjects.GetDataForDropDown(gen_applicanttablesEntity gen_applicanttables, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_applicanttablesDataAccess().GetDataForDropDown(gen_applicanttables,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_applicanttablesEntity> Igen_applicanttablesFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}