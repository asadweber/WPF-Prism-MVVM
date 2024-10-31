
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
    public sealed partial class gen_residenttypeFacadeObjects : BaseFacade, Igen_residenttypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_residenttypeFacadeObjects";
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

        public gen_residenttypeFacadeObjects()
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

        ~gen_residenttypeFacadeObjects()
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
		
		async Task<long> Igen_residenttypeFacadeObjects.Delete(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_residenttypeDataAccess().Delete(gen_residenttype, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_residenttypeFacade.Deletegen_residenttype"));
            }
        }
		
		async Task<long> Igen_residenttypeFacadeObjects.Update(gen_residenttypeEntity gen_residenttype , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().Update(gen_residenttype,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_residenttypeFacade.Updategen_residenttype"));
            }
		}
		
		async Task<long> Igen_residenttypeFacadeObjects.Add(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().Add(gen_residenttype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_residenttypeFacade.Addgen_residenttype"));
            }
		}
		
        async Task<long> Igen_residenttypeFacadeObjects.SaveList(List<gen_residenttypeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_residenttypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_residenttypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_residenttypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_residenttypeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_residenttype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_residenttypeEntity>> Igen_residenttypeFacadeObjects.GetAll(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().GetAll(gen_residenttype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_residenttypeEntity> Igen_residenttypeFacade.GetAllgen_residenttype"));
            }
		}
		
		async Task<IList<gen_residenttypeEntity>> Igen_residenttypeFacadeObjects.GetAllByPages(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().GetAllByPages(gen_residenttype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_residenttypeEntity> Igen_residenttypeFacade.GetAllByPagesgen_residenttype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_residenttypeFacadeObjects.SaveMasterDetreg_basicinfo(gen_residenttypeEntity Master, List<reg_basicinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_basicinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_basicinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_basicinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_residenttypeDataAccess().SaveMasterDetreg_basicinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_basicinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_residenttypeEntity>  Igen_residenttypeFacadeObjects.GetSingle(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().GetSingle(gen_residenttype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_residenttypeEntity Igen_residenttypeFacade.GetSinglegen_residenttype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_residenttypeEntity>> Igen_residenttypeFacadeObjects.GAPgListView(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().GAPgListView(gen_residenttype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_residenttypeEntity> Igen_residenttypeFacade.GAPgListViewgen_residenttype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_residenttypeFacadeObjects.GetDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().GetDataForDropDown(gen_residenttype,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_residenttypeEntity> Igen_residenttypeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}