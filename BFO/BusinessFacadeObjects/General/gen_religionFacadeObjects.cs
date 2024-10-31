
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
    public sealed partial class gen_religionFacadeObjects : BaseFacade, Igen_religionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_religionFacadeObjects";
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

        public gen_religionFacadeObjects()
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

        ~gen_religionFacadeObjects()
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
		
		async Task<long> Igen_religionFacadeObjects.Delete(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_religionDataAccess().Delete(gen_religion, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_religionFacade.Deletegen_religion"));
            }
        }
		
		async Task<long> Igen_religionFacadeObjects.Update(gen_religionEntity gen_religion , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().Update(gen_religion,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_religionFacade.Updategen_religion"));
            }
		}
		
		async Task<long> Igen_religionFacadeObjects.Add(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().Add(gen_religion, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_religionFacade.Addgen_religion"));
            }
		}
		
        async Task<long> Igen_religionFacadeObjects.SaveList(List<gen_religionEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_religionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_religionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_religionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_religionDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_religion"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_religionEntity>> Igen_religionFacadeObjects.GetAll(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().GetAll(gen_religion, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> Igen_religionFacade.GetAllgen_religion"));
            }
		}
		
		async Task<IList<gen_religionEntity>> Igen_religionFacadeObjects.GetAllByPages(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().GetAllByPages(gen_religion,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> Igen_religionFacade.GetAllByPagesgen_religion"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_religionFacadeObjects.SaveMasterDetreg_familly(gen_religionEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_religionDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_religionEntity>  Igen_religionFacadeObjects.GetSingle(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().GetSingle(gen_religion,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_religionEntity Igen_religionFacade.GetSinglegen_religion"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_religionEntity>> Igen_religionFacadeObjects.GAPgListView(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().GAPgListView(gen_religion,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> Igen_religionFacade.GAPgListViewgen_religion"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_religionFacadeObjects.GetDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().GetDataForDropDown(gen_religion,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> Igen_religionFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}