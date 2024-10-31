
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
    public sealed partial class cnf_studentmenuskipdetailFacadeObjects : BaseFacade, Icnf_studentmenuskipdetailFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_studentmenuskipdetailFacadeObjects";
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

        public cnf_studentmenuskipdetailFacadeObjects()
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

        ~cnf_studentmenuskipdetailFacadeObjects()
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
		
		async Task<long> Icnf_studentmenuskipdetailFacadeObjects.Delete(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().Delete(cnf_studentmenuskipdetail, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipdetailFacade.Deletecnf_studentmenuskipdetail"));
            }
        }
		
		async Task<long> Icnf_studentmenuskipdetailFacadeObjects.Update(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().Update(cnf_studentmenuskipdetail,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipdetailFacade.Updatecnf_studentmenuskipdetail"));
            }
		}
		
		async Task<long> Icnf_studentmenuskipdetailFacadeObjects.Add(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().Add(cnf_studentmenuskipdetail, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipdetailFacade.Addcnf_studentmenuskipdetail"));
            }
		}
		
        async Task<long> Icnf_studentmenuskipdetailFacadeObjects.SaveList(List<cnf_studentmenuskipdetailEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_studentmenuskipdetailEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_studentmenuskipdetailEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_studentmenuskipdetailEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_studentmenuskipdetail"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailFacadeObjects.GetAll(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().GetAll(cnf_studentmenuskipdetail, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipdetailEntity> Icnf_studentmenuskipdetailFacade.GetAllcnf_studentmenuskipdetail"));
            }
		}
		
		async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailFacadeObjects.GetAllByPages(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().GetAllByPages(cnf_studentmenuskipdetail,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipdetailEntity> Icnf_studentmenuskipdetailFacade.GetAllByPagescnf_studentmenuskipdetail"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_studentmenuskipdetailEntity>  Icnf_studentmenuskipdetailFacadeObjects.GetSingle(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().GetSingle(cnf_studentmenuskipdetail,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_studentmenuskipdetailEntity Icnf_studentmenuskipdetailFacade.GetSinglecnf_studentmenuskipdetail"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailFacadeObjects.GAPgListView(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().GAPgListView(cnf_studentmenuskipdetail,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipdetailEntity> Icnf_studentmenuskipdetailFacade.GAPgListViewcnf_studentmenuskipdetail"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}