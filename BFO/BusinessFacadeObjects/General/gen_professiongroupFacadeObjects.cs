
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
    public sealed partial class gen_professiongroupFacadeObjects : BaseFacade, Igen_professiongroupFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_professiongroupFacadeObjects";
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

        public gen_professiongroupFacadeObjects()
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

        ~gen_professiongroupFacadeObjects()
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
		
		async Task<long> Igen_professiongroupFacadeObjects.Delete(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_professiongroupDataAccess().Delete(gen_professiongroup, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_professiongroupFacade.Deletegen_professiongroup"));
            }
        }
		
		async Task<long> Igen_professiongroupFacadeObjects.Update(gen_professiongroupEntity gen_professiongroup , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().Update(gen_professiongroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_professiongroupFacade.Updategen_professiongroup"));
            }
		}
		
		async Task<long> Igen_professiongroupFacadeObjects.Add(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().Add(gen_professiongroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_professiongroupFacade.Addgen_professiongroup"));
            }
		}
		
        async Task<long> Igen_professiongroupFacadeObjects.SaveList(List<gen_professiongroupEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_professiongroupEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_professiongroupEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_professiongroupEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_professiongroupDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_professiongroup"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_professiongroupEntity>> Igen_professiongroupFacadeObjects.GetAll(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().GetAll(gen_professiongroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professiongroupEntity> Igen_professiongroupFacade.GetAllgen_professiongroup"));
            }
		}
		
		async Task<IList<gen_professiongroupEntity>> Igen_professiongroupFacadeObjects.GetAllByPages(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().GetAllByPages(gen_professiongroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professiongroupEntity> Igen_professiongroupFacade.GetAllByPagesgen_professiongroup"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_professiongroupFacadeObjects.SaveMasterDetgen_profession(gen_professiongroupEntity Master, List<gen_professionEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_professionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_professionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_professionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_professiongroupDataAccess().SaveMasterDetgen_profession(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_profession"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_professiongroupEntity>  Igen_professiongroupFacadeObjects.GetSingle(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().GetSingle(gen_professiongroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_professiongroupEntity Igen_professiongroupFacade.GetSinglegen_professiongroup"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_professiongroupEntity>> Igen_professiongroupFacadeObjects.GAPgListView(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().GAPgListView(gen_professiongroup,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professiongroupEntity> Igen_professiongroupFacade.GAPgListViewgen_professiongroup"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_professiongroupFacadeObjects.GetDataForDropDown(gen_professiongroupEntity gen_professiongroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professiongroupDataAccess().GetDataForDropDown(gen_professiongroup,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_professiongroupEntity> Igen_professiongroupFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}