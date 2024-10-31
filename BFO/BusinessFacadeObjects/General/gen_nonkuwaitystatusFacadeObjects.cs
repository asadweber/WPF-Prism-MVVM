
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
    public sealed partial class gen_nonkuwaitystatusFacadeObjects : BaseFacade, Igen_nonkuwaitystatusFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_nonkuwaitystatusFacadeObjects";
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

        public gen_nonkuwaitystatusFacadeObjects()
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

        ~gen_nonkuwaitystatusFacadeObjects()
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
		
		async Task<long> Igen_nonkuwaitystatusFacadeObjects.Delete(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().Delete(gen_nonkuwaitystatus, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_nonkuwaitystatusFacade.Deletegen_nonkuwaitystatus"));
            }
        }
		
		async Task<long> Igen_nonkuwaitystatusFacadeObjects.Update(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().Update(gen_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_nonkuwaitystatusFacade.Updategen_nonkuwaitystatus"));
            }
		}
		
		async Task<long> Igen_nonkuwaitystatusFacadeObjects.Add(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().Add(gen_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_nonkuwaitystatusFacade.Addgen_nonkuwaitystatus"));
            }
		}
		
        async Task<long> Igen_nonkuwaitystatusFacadeObjects.SaveList(List<gen_nonkuwaitystatusEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_nonkuwaitystatusEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_nonkuwaitystatusEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_nonkuwaitystatusEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_nonkuwaitystatus"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusFacadeObjects.GetAll(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GetAll(gen_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusFacade.GetAllgen_nonkuwaitystatus"));
            }
		}
		
		async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusFacadeObjects.GetAllByPages(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GetAllByPages(gen_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusFacade.GetAllByPagesgen_nonkuwaitystatus"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_nonkuwaitystatusFacadeObjects.SaveMasterDetreg_nonkuwaitystatus(gen_nonkuwaitystatusEntity Master, List<reg_nonkuwaitystatusEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_nonkuwaitystatusEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_nonkuwaitystatusEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_nonkuwaitystatusEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().SaveMasterDetreg_nonkuwaitystatus(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_nonkuwaitystatus"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_nonkuwaitystatusEntity>  Igen_nonkuwaitystatusFacadeObjects.GetSingle(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GetSingle(gen_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_nonkuwaitystatusEntity Igen_nonkuwaitystatusFacade.GetSinglegen_nonkuwaitystatus"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusFacadeObjects.GAPgListView(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GAPgListView(gen_nonkuwaitystatus,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusFacade.GAPgListViewgen_nonkuwaitystatus"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_nonkuwaitystatusFacadeObjects.GetDataForDropDown(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GetDataForDropDown(gen_nonkuwaitystatus,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}