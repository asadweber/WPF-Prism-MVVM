
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
    public sealed partial class tran_applicantretestapprovalFacadeObjects : BaseFacade, Itran_applicantretestapprovalFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "tran_applicantretestapprovalFacadeObjects";
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

        public tran_applicantretestapprovalFacadeObjects()
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

        ~tran_applicantretestapprovalFacadeObjects()
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
		
		async Task<long> Itran_applicantretestapprovalFacadeObjects.Delete(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().Delete(tran_applicantretestapproval, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantretestapprovalFacade.Deletetran_applicantretestapproval"));
            }
        }
		
		async Task<long> Itran_applicantretestapprovalFacadeObjects.Update(tran_applicantretestapprovalEntity tran_applicantretestapproval , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().Update(tran_applicantretestapproval,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Itran_applicantretestapprovalFacade.Updatetran_applicantretestapproval"));
            }
		}
		
		async Task<long> Itran_applicantretestapprovalFacadeObjects.Add(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().Add(tran_applicantretestapproval, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantretestapprovalFacade.Addtran_applicantretestapproval"));
            }
		}
		
        async Task<long> Itran_applicantretestapprovalFacadeObjects.SaveList(List<tran_applicantretestapprovalEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<tran_applicantretestapprovalEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<tran_applicantretestapprovalEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<tran_applicantretestapprovalEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_tran_applicantretestapproval"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<tran_applicantretestapprovalEntity>> Itran_applicantretestapprovalFacadeObjects.GetAll(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().GetAll(tran_applicantretestapproval, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantretestapprovalEntity> Itran_applicantretestapprovalFacade.GetAlltran_applicantretestapproval"));
            }
		}
		
		async Task<IList<tran_applicantretestapprovalEntity>> Itran_applicantretestapprovalFacadeObjects.GetAllByPages(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().GetAllByPages(tran_applicantretestapproval,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantretestapprovalEntity> Itran_applicantretestapprovalFacade.GetAllByPagestran_applicantretestapproval"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<tran_applicantretestapprovalEntity>  Itran_applicantretestapprovalFacadeObjects.GetSingle(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().GetSingle(tran_applicantretestapproval,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("tran_applicantretestapprovalEntity Itran_applicantretestapprovalFacade.GetSingletran_applicantretestapproval"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<tran_applicantretestapprovalEntity>> Itran_applicantretestapprovalFacadeObjects.GAPgListView(tran_applicantretestapprovalEntity tran_applicantretestapproval, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantretestapprovalDataAccess().GAPgListView(tran_applicantretestapproval,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantretestapprovalEntity> Itran_applicantretestapprovalFacade.GAPgListViewtran_applicantretestapproval"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}