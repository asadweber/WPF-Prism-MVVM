


using AppConfig.ConfigDAAC;
using BDO.Core.Base;
using BDO.Core.DataAccessObjects.SecurityModels;
using BFO.Base;
using DAC.Core.CoreFactory;
using IBFO.Core.IBusinessFacadeObjects.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BFO.Core.BusinessFacadeObjects.Security
{
    public sealed partial class owin_formactionFacadeObjects : BaseFacade, Iowin_formactionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "owin_formactionFacadeObjects";
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

        public owin_formactionFacadeObjects()
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

        ~owin_formactionFacadeObjects()
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
		
		async Task<long> Iowin_formactionFacadeObjects.Delete(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createowin_formactionDataAccess().Delete(owin_formaction, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_formactionFacade.Deleteowin_formaction"));
            }
        }
		
		async Task<long> Iowin_formactionFacadeObjects.Update(owin_formactionEntity owin_formaction , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_formactionDataAccess().Update(owin_formaction,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Iowin_formactionFacade.Updateowin_formaction"));
            }
		}
		
		async Task<long> Iowin_formactionFacadeObjects.Add(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_formactionDataAccess().Add(owin_formaction, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Iowin_formactionFacade.Addowin_formaction"));
            }
		}
		
        async Task<long> Iowin_formactionFacadeObjects.SaveList(List<owin_formactionEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<owin_formactionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<owin_formactionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<owin_formactionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createowin_formactionDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_owin_formaction"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<owin_formactionEntity>> Iowin_formactionFacadeObjects.GetAll(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_formactionDataAccess().GetAll(owin_formaction, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GetAllowin_formaction"));
            }
		}
		
		async Task<IList<owin_formactionEntity>> Iowin_formactionFacadeObjects.GetAllByPages(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_formactionDataAccess().GetAllByPages(owin_formaction,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GetAllByPagesowin_formaction"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Iowin_formactionFacadeObjects.SaveMasterDetowin_formaction(owin_formactionEntity Master, List<owin_formactionEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createowin_formactionDataAccess().SaveMasterDetowin_formaction(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_formaction"));
               }
        }
        
        
        async Task<long> Iowin_formactionFacadeObjects.SaveMasterDetowin_rolepermission(owin_formactionEntity Master, List<owin_rolepermissionEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Createowin_formactionDataAccess().SaveMasterDetowin_rolepermission(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetowin_rolepermission"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<owin_formactionEntity>  Iowin_formactionFacadeObjects.GetSingle(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_formactionDataAccess().GetSingle(owin_formaction,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("owin_formactionEntity Iowin_formactionFacade.GetSingleowin_formaction"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<owin_formactionEntity>> Iowin_formactionFacadeObjects.GAPgListView(owin_formactionEntity owin_formaction, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createowin_formactionDataAccess().GAPgListView(owin_formaction,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<owin_formactionEntity> Iowin_formactionFacade.GAPgListViewowin_formaction"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
        #endregion
	}
}