
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
    public sealed partial class gen_servicestypeFacadeObjects : BaseFacade, Igen_servicestypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_servicestypeFacadeObjects";
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

        public gen_servicestypeFacadeObjects()
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

        ~gen_servicestypeFacadeObjects()
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
		
		async Task<long> Igen_servicestypeFacadeObjects.Delete(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_servicestypeDataAccess().Delete(gen_servicestype, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicestypeFacade.Deletegen_servicestype"));
            }
        }
		
		async Task<long> Igen_servicestypeFacadeObjects.Update(gen_servicestypeEntity gen_servicestype , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().Update(gen_servicestype,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_servicestypeFacade.Updategen_servicestype"));
            }
		}
		
		async Task<long> Igen_servicestypeFacadeObjects.Add(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().Add(gen_servicestype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_servicestypeFacade.Addgen_servicestype"));
            }
		}
		
        async Task<long> Igen_servicestypeFacadeObjects.SaveList(List<gen_servicestypeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_servicestypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_servicestypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_servicestypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_servicestypeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_servicestype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_servicestypeEntity>> Igen_servicestypeFacadeObjects.GetAll(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().GetAll(gen_servicestype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestypeEntity> Igen_servicestypeFacade.GetAllgen_servicestype"));
            }
		}
		
		async Task<IList<gen_servicestypeEntity>> Igen_servicestypeFacadeObjects.GetAllByPages(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().GetAllByPages(gen_servicestype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestypeEntity> Igen_servicestypeFacade.GetAllByPagesgen_servicestype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_servicestypeFacadeObjects.SaveMasterDetgen_services(gen_servicestypeEntity Master, List<gen_servicesEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_servicesEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_servicesEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_servicesEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_servicestypeDataAccess().SaveMasterDetgen_services(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_services"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_servicestypeEntity>  Igen_servicestypeFacadeObjects.GetSingle(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().GetSingle(gen_servicestype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_servicestypeEntity Igen_servicestypeFacade.GetSinglegen_servicestype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_servicestypeEntity>> Igen_servicestypeFacadeObjects.GAPgListView(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().GAPgListView(gen_servicestype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_servicestypeEntity> Igen_servicestypeFacade.GAPgListViewgen_servicestype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_servicestypeFacadeObjects.GetDataForDropDown(gen_servicestypeEntity gen_servicestype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_servicestypeDataAccess().GetDataForDropDown(gen_servicestype,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_servicestypeEntity> Igen_servicestypeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}