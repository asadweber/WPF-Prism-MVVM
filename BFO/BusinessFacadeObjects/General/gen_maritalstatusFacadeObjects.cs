
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
    public sealed partial class gen_maritalstatusFacadeObjects : BaseFacade, Igen_maritalstatusFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_maritalstatusFacadeObjects";
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

        public gen_maritalstatusFacadeObjects()
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

        ~gen_maritalstatusFacadeObjects()
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
		
		async Task<long> Igen_maritalstatusFacadeObjects.Delete(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().Delete(gen_maritalstatus, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Deletegen_maritalstatus"));
            }
        }
		
		async Task<long> Igen_maritalstatusFacadeObjects.Update(gen_maritalstatusEntity gen_maritalstatus , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().Update(gen_maritalstatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Updategen_maritalstatus"));
            }
		}
		
		async Task<long> Igen_maritalstatusFacadeObjects.Add(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().Add(gen_maritalstatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_maritalstatusFacade.Addgen_maritalstatus"));
            }
		}
		
        async Task<long> Igen_maritalstatusFacadeObjects.SaveList(List<gen_maritalstatusEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_maritalstatusEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_maritalstatusEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_maritalstatusEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_maritalstatusDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_maritalstatus"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusFacadeObjects.GetAll(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().GetAll(gen_maritalstatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetAllgen_maritalstatus"));
            }
		}
		
		async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusFacadeObjects.GetAllByPages(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().GetAllByPages(gen_maritalstatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetAllByPagesgen_maritalstatus"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_maritalstatusFacadeObjects.SaveMasterDetreg_familly(gen_maritalstatusEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_maritalstatusDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_maritalstatusEntity>  Igen_maritalstatusFacadeObjects.GetSingle(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().GetSingle(gen_maritalstatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_maritalstatusEntity Igen_maritalstatusFacade.GetSinglegen_maritalstatus"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_maritalstatusEntity>> Igen_maritalstatusFacadeObjects.GAPgListView(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().GAPgListView(gen_maritalstatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GAPgListViewgen_maritalstatus"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_maritalstatusFacadeObjects.GetDataForDropDown(gen_maritalstatusEntity gen_maritalstatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_maritalstatusDataAccess().GetDataForDropDown(gen_maritalstatus,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_maritalstatusEntity> Igen_maritalstatusFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}