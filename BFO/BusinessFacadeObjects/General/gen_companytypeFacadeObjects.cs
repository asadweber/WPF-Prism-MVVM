
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
    public sealed partial class gen_companytypeFacadeObjects : BaseFacade, Igen_companytypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_companytypeFacadeObjects";
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

        public gen_companytypeFacadeObjects()
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

        ~gen_companytypeFacadeObjects()
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
		
		async Task<long> Igen_companytypeFacadeObjects.Delete(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_companytypeDataAccess().Delete(gen_companytype, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_companytypeFacade.Deletegen_companytype"));
            }
        }
		
		async Task<long> Igen_companytypeFacadeObjects.Update(gen_companytypeEntity gen_companytype , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().Update(gen_companytype,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_companytypeFacade.Updategen_companytype"));
            }
		}
		
		async Task<long> Igen_companytypeFacadeObjects.Add(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().Add(gen_companytype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_companytypeFacade.Addgen_companytype"));
            }
		}
		
        async Task<long> Igen_companytypeFacadeObjects.SaveList(List<gen_companytypeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_companytypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_companytypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_companytypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_companytypeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_companytype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_companytypeEntity>> Igen_companytypeFacadeObjects.GetAll(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().GetAll(gen_companytype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companytypeEntity> Igen_companytypeFacade.GetAllgen_companytype"));
            }
		}
		
		async Task<IList<gen_companytypeEntity>> Igen_companytypeFacadeObjects.GetAllByPages(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().GetAllByPages(gen_companytype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companytypeEntity> Igen_companytypeFacade.GetAllByPagesgen_companytype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_companytypeFacadeObjects.SaveMasterDetgen_companies(gen_companytypeEntity Master, List<gen_companiesEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_companiesEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_companiesEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_companiesEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_companytypeDataAccess().SaveMasterDetgen_companies(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_companies"));
               }
        }
        
        
        async Task<long> Igen_companytypeFacadeObjects.SaveMasterDetreg_previousexperiance(gen_companytypeEntity Master, List<reg_previousexperianceEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_previousexperianceEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_previousexperianceEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_previousexperianceEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_companytypeDataAccess().SaveMasterDetreg_previousexperiance(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_previousexperiance"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_companytypeEntity>  Igen_companytypeFacadeObjects.GetSingle(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().GetSingle(gen_companytype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_companytypeEntity Igen_companytypeFacade.GetSinglegen_companytype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_companytypeEntity>> Igen_companytypeFacadeObjects.GAPgListView(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().GAPgListView(gen_companytype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companytypeEntity> Igen_companytypeFacade.GAPgListViewgen_companytype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_companytypeFacadeObjects.GetDataForDropDown(gen_companytypeEntity gen_companytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companytypeDataAccess().GetDataForDropDown(gen_companytype,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_companytypeEntity> Igen_companytypeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}