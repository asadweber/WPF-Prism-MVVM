
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
    public sealed partial class tran_exportprofileFacadeObjects : BaseFacade, Itran_exportprofileFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_exportprofileFacadeObjects";
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

        public tran_exportprofileFacadeObjects()
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

        ~tran_exportprofileFacadeObjects()
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
		
		async Task<long> Itran_exportprofileFacadeObjects.Delete(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_exportprofileDataAccess().Delete(tran_exportprofile, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_exportprofileFacade.Deletetran_exportprofile"));
            }
        }
		
		async Task<long> Itran_exportprofileFacadeObjects.Update(tran_exportprofileEntity tran_exportprofile , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().Update(tran_exportprofile,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_exportprofileFacade.Updatetran_exportprofile"));
            }
		}
		
		async Task<long> Itran_exportprofileFacadeObjects.Add(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().Add(tran_exportprofile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_exportprofileFacade.Addtran_exportprofile"));
            }
		}
		
        async Task<long> Itran_exportprofileFacadeObjects.SaveList(List<tran_exportprofileEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_exportprofileEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_exportprofileEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_exportprofileEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_exportprofileDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_exportprofile"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_exportprofileEntity>> Itran_exportprofileFacadeObjects.GetAll(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().GetAll(tran_exportprofile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_exportprofileEntity> Itran_exportprofileFacade.GetAlltran_exportprofile"));
            }
		}
		
		async Task<IList<tran_exportprofileEntity>> Itran_exportprofileFacadeObjects.GetAllByPages(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().GetAllByPages(tran_exportprofile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_exportprofileEntity> Itran_exportprofileFacade.GetAllByPagestran_exportprofile"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_exportprofileEntity>  Itran_exportprofileFacadeObjects.GetSingle(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().GetSingle(tran_exportprofile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_exportprofileEntity Itran_exportprofileFacade.GetSingletran_exportprofile"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_exportprofileEntity>> Itran_exportprofileFacadeObjects.GAPgListView(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().GAPgListView(tran_exportprofile,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_exportprofileEntity> Itran_exportprofileFacade.GAPgListViewtran_exportprofile"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}