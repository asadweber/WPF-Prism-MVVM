
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
    public sealed partial class gen_educationshiftFacadeObjects : BaseFacade, Igen_educationshiftFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_educationshiftFacadeObjects";
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

        public gen_educationshiftFacadeObjects()
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

        ~gen_educationshiftFacadeObjects()
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
		
		async Task<long> Igen_educationshiftFacadeObjects.Delete(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_educationshiftDataAccess().Delete(gen_educationshift, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationshiftFacade.Deletegen_educationshift"));
            }
        }
		
		async Task<long> Igen_educationshiftFacadeObjects.Update(gen_educationshiftEntity gen_educationshift , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().Update(gen_educationshift,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_educationshiftFacade.Updategen_educationshift"));
            }
		}
		
		async Task<long> Igen_educationshiftFacadeObjects.Add(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().Add(gen_educationshift, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationshiftFacade.Addgen_educationshift"));
            }
		}
		
        async Task<long> Igen_educationshiftFacadeObjects.SaveList(List<gen_educationshiftEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_educationshiftEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_educationshiftEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_educationshiftEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_educationshiftDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_educationshift"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_educationshiftEntity>> Igen_educationshiftFacadeObjects.GetAll(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().GetAll(gen_educationshift, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationshiftEntity> Igen_educationshiftFacade.GetAllgen_educationshift"));
            }
		}
		
		async Task<IList<gen_educationshiftEntity>> Igen_educationshiftFacadeObjects.GetAllByPages(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().GetAllByPages(gen_educationshift,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationshiftEntity> Igen_educationshiftFacade.GetAllByPagesgen_educationshift"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_educationshiftFacadeObjects.SaveMasterDetreg_educationinfo(gen_educationshiftEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_educationshiftDataAccess().SaveMasterDetreg_educationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_educationinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_educationshiftEntity>  Igen_educationshiftFacadeObjects.GetSingle(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().GetSingle(gen_educationshift,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_educationshiftEntity Igen_educationshiftFacade.GetSinglegen_educationshift"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_educationshiftEntity>> Igen_educationshiftFacadeObjects.GAPgListView(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().GAPgListView(gen_educationshift,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationshiftEntity> Igen_educationshiftFacade.GAPgListViewgen_educationshift"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_educationshiftFacadeObjects.GetDataForDropDown(gen_educationshiftEntity gen_educationshift, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationshiftDataAccess().GetDataForDropDown(gen_educationshift,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_educationshiftEntity> Igen_educationshiftFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}