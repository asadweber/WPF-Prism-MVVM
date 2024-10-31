
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
    public sealed partial class cnf_studentmenuskipFacadeObjects : BaseFacade, Icnf_studentmenuskipFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_studentmenuskipFacadeObjects";
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

        public cnf_studentmenuskipFacadeObjects()
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

        ~cnf_studentmenuskipFacadeObjects()
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
		
		async Task<long> Icnf_studentmenuskipFacadeObjects.Delete(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().Delete(cnf_studentmenuskip, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipFacade.Deletecnf_studentmenuskip"));
            }
        }
		
		async Task<long> Icnf_studentmenuskipFacadeObjects.Update(cnf_studentmenuskipEntity cnf_studentmenuskip , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().Update(cnf_studentmenuskip,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipFacade.Updatecnf_studentmenuskip"));
            }
		}
		
		async Task<long> Icnf_studentmenuskipFacadeObjects.Add(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().Add(cnf_studentmenuskip, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipFacade.Addcnf_studentmenuskip"));
            }
		}
		
        async Task<long> Icnf_studentmenuskipFacadeObjects.SaveList(List<cnf_studentmenuskipEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_studentmenuskipEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_studentmenuskipEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_studentmenuskipEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_studentmenuskip"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipFacadeObjects.GetAll(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().GetAll(cnf_studentmenuskip, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipEntity> Icnf_studentmenuskipFacade.GetAllcnf_studentmenuskip"));
            }
		}
		
		async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipFacadeObjects.GetAllByPages(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().GetAllByPages(cnf_studentmenuskip,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipEntity> Icnf_studentmenuskipFacade.GetAllByPagescnf_studentmenuskip"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Icnf_studentmenuskipFacadeObjects.SaveMasterDetcnf_studentmenuskipdetail(cnf_studentmenuskipEntity Master, List<cnf_studentmenuskipdetailEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_studentmenuskipdetailEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_studentmenuskipdetailEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_studentmenuskipdetailEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().SaveMasterDetcnf_studentmenuskipdetail(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_studentmenuskipdetail"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_studentmenuskipEntity>  Icnf_studentmenuskipFacadeObjects.GetSingle(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().GetSingle(cnf_studentmenuskip,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_studentmenuskipEntity Icnf_studentmenuskipFacade.GetSinglecnf_studentmenuskip"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipFacadeObjects.GAPgListView(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().GAPgListView(cnf_studentmenuskip,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipEntity> Icnf_studentmenuskipFacade.GAPgListViewcnf_studentmenuskip"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_studentmenuskipFacadeObjects.GetDataForDropDown(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().GetDataForDropDown(cnf_studentmenuskip,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipEntity> Icnf_studentmenuskipFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}