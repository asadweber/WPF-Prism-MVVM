
using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
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
    public sealed partial class owin_forminfoFacadeObjects : BaseFacade, Iowin_forminfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_forminfoFacadeObjects";
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

        public owin_forminfoFacadeObjects()
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

        ~owin_forminfoFacadeObjects()
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
		
		async Task<long> Iowin_forminfoFacadeObjects.Delete(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_forminfoDataAccess().Delete(owin_forminfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_forminfoFacade.Deleteowin_forminfo"));
            }
        }
		
		async Task<long> Iowin_forminfoFacadeObjects.Update(owin_forminfoEntity owin_forminfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().Update(owin_forminfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_forminfoFacade.Updateowin_forminfo"));
            }
		}
		
		async Task<long> Iowin_forminfoFacadeObjects.Add(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().Add(owin_forminfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_forminfoFacade.Addowin_forminfo"));
            }
		}
		
        async Task<long> Iowin_forminfoFacadeObjects.SaveList(List<owin_forminfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_forminfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_forminfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_forminfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_forminfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_forminfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_forminfoEntity>> Iowin_forminfoFacadeObjects.GetAll(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().GetAll(owin_forminfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_forminfoEntity> Iowin_forminfoFacade.GetAllowin_forminfo"));
            }
		}
		
		async Task<IList<owin_forminfoEntity>> Iowin_forminfoFacadeObjects.GetAllByPages(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().GetAllByPages(owin_forminfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_forminfoEntity> Iowin_forminfoFacade.GetAllByPagesowin_forminfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        
        async Task<long> Iowin_forminfoFacadeObjects.SaveMasterDetowin_formaction(owin_forminfoEntity Master, List<owin_formactionEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_formactionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_formactionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_formactionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_forminfoDataAccess().SaveMasterDetowin_formaction(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_formaction"));
               }
        }
        
        
        async Task<long> Iowin_forminfoFacadeObjects.SaveMasterDetowin_rolepermission(owin_forminfoEntity Master, List<owin_rolepermissionEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<owin_rolepermissionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<owin_rolepermissionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<owin_rolepermissionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createowin_forminfoDataAccess().SaveMasterDetowin_rolepermission(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_rolepermission"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_forminfoEntity>  Iowin_forminfoFacadeObjects.GetSingle(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().GetSingle(owin_forminfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_forminfoEntity Iowin_forminfoFacade.GetSingleowin_forminfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_forminfoEntity>> Iowin_forminfoFacadeObjects.GAPgListView(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().GAPgListView(owin_forminfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_forminfoEntity> Iowin_forminfoFacade.GAPgListViewowin_forminfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Iowin_forminfoFacadeObjects.GetDataForDropDown(owin_forminfoEntity owin_forminfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_forminfoDataAccess().GetDataForDropDown(owin_forminfo,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<owin_forminfoEntity> Iowin_forminfoFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}