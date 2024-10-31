
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
    public sealed partial class gen_bloodgroupFacadeObjects : BaseFacade, Igen_bloodgroupFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_bloodgroupFacadeObjects";
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

        public gen_bloodgroupFacadeObjects()
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

        ~gen_bloodgroupFacadeObjects()
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
		
		async Task<long> Igen_bloodgroupFacadeObjects.Delete(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().Delete(gen_bloodgroup, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Deletegen_bloodgroup"));
            }
        }
		
		async Task<long> Igen_bloodgroupFacadeObjects.Update(gen_bloodgroupEntity gen_bloodgroup , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().Update(gen_bloodgroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Updategen_bloodgroup"));
            }
		}
		
		async Task<long> Igen_bloodgroupFacadeObjects.Add(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().Add(gen_bloodgroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Addgen_bloodgroup"));
            }
		}
		
        async Task<long> Igen_bloodgroupFacadeObjects.SaveList(List<gen_bloodgroupEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_bloodgroupEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_bloodgroupEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_bloodgroupEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_bloodgroupDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_bloodgroup"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupFacadeObjects.GetAll(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().GetAll(gen_bloodgroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetAllgen_bloodgroup"));
            }
		}
		
		async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupFacadeObjects.GetAllByPages(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().GetAllByPages(gen_bloodgroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetAllByPagesgen_bloodgroup"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_bloodgroupFacadeObjects.SaveMasterDetreg_familly(gen_bloodgroupEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_bloodgroupDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_bloodgroupEntity>  Igen_bloodgroupFacadeObjects.GetSingle(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().GetSingle(gen_bloodgroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_bloodgroupEntity Igen_bloodgroupFacade.GetSinglegen_bloodgroup"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupFacadeObjects.GAPgListView(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().GAPgListView(gen_bloodgroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GAPgListViewgen_bloodgroup"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_bloodgroupFacadeObjects.GetDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().GetDataForDropDown(gen_bloodgroup,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}