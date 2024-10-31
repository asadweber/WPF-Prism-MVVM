
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
    public sealed partial class gen_companiesFacadeObjects : BaseFacade, Igen_companiesFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_companiesFacadeObjects";
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

        public gen_companiesFacadeObjects()
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

        ~gen_companiesFacadeObjects()
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
		
		async Task<long> Igen_companiesFacadeObjects.Delete(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_companiesDataAccess().Delete(gen_companies, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_companiesFacade.Deletegen_companies"));
            }
        }
		
		async Task<long> Igen_companiesFacadeObjects.Update(gen_companiesEntity gen_companies , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().Update(gen_companies,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_companiesFacade.Updategen_companies"));
            }
		}
		
		async Task<long> Igen_companiesFacadeObjects.Add(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().Add(gen_companies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_companiesFacade.Addgen_companies"));
            }
		}
		
        async Task<long> Igen_companiesFacadeObjects.SaveList(List<gen_companiesEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_companiesEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_companiesEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_companiesEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_companiesDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_companies"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_companiesEntity>> Igen_companiesFacadeObjects.GetAll(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().GetAll(gen_companies, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companiesEntity> Igen_companiesFacade.GetAllgen_companies"));
            }
		}
		
		async Task<IList<gen_companiesEntity>> Igen_companiesFacadeObjects.GetAllByPages(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().GetAllByPages(gen_companies,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companiesEntity> Igen_companiesFacade.GetAllByPagesgen_companies"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_companiesFacadeObjects.SaveMasterDetreg_familly(gen_companiesEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_companiesDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        async Task<long> Igen_companiesFacadeObjects.SaveMasterDetreg_previousexperiance(gen_companiesEntity Master, List<reg_previousexperianceEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_companiesDataAccess().SaveMasterDetreg_previousexperiance(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_previousexperiance"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_companiesEntity>  Igen_companiesFacadeObjects.GetSingle(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().GetSingle(gen_companies,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_companiesEntity Igen_companiesFacade.GetSinglegen_companies"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_companiesEntity>> Igen_companiesFacadeObjects.GAPgListView(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().GAPgListView(gen_companies,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_companiesEntity> Igen_companiesFacade.GAPgListViewgen_companies"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_companiesFacadeObjects.GetDataForDropDown(gen_companiesEntity gen_companies, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_companiesDataAccess().GetDataForDropDown(gen_companies,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_companiesEntity> Igen_companiesFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}