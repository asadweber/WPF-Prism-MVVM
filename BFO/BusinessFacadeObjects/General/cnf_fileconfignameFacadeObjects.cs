
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
    public sealed partial class cnf_fileconfignameFacadeObjects : BaseFacade, Icnf_fileconfignameFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_fileconfignameFacadeObjects";
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

        public cnf_fileconfignameFacadeObjects()
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

        ~cnf_fileconfignameFacadeObjects()
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
		
		async Task<long> Icnf_fileconfignameFacadeObjects.Delete(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().Delete(cnf_fileconfigname, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_fileconfignameFacade.Deletecnf_fileconfigname"));
            }
        }
		
		async Task<long> Icnf_fileconfignameFacadeObjects.Update(cnf_fileconfignameEntity cnf_fileconfigname , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().Update(cnf_fileconfigname,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_fileconfignameFacade.Updatecnf_fileconfigname"));
            }
		}
		
		async Task<long> Icnf_fileconfignameFacadeObjects.Add(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().Add(cnf_fileconfigname, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_fileconfignameFacade.Addcnf_fileconfigname"));
            }
		}
		
        async Task<long> Icnf_fileconfignameFacadeObjects.SaveList(List<cnf_fileconfignameEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_fileconfignameEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_fileconfignameEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_fileconfignameEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_fileconfignameDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_fileconfigname"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameFacadeObjects.GetAll(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().GetAll(cnf_fileconfigname, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_fileconfignameEntity> Icnf_fileconfignameFacade.GetAllcnf_fileconfigname"));
            }
		}
		
		async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameFacadeObjects.GetAllByPages(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().GetAllByPages(cnf_fileconfigname,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_fileconfignameEntity> Icnf_fileconfignameFacade.GetAllByPagescnf_fileconfigname"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_fileconfignameEntity>  Icnf_fileconfignameFacadeObjects.GetSingle(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().GetSingle(cnf_fileconfigname,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_fileconfignameEntity Icnf_fileconfignameFacade.GetSinglecnf_fileconfigname"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameFacadeObjects.GAPgListView(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_fileconfignameDataAccess().GAPgListView(cnf_fileconfigname,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_fileconfignameEntity> Icnf_fileconfignameFacade.GAPgListViewcnf_fileconfigname"));
            }
		}
        #endregion

        #region Extras Reviewed, Published, Archived
        #endregion

        #region for Dropdown 
        async Task<IList<gen_dropdownEntity>> Icnf_fileconfignameFacadeObjects.GetDataForDropDown(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_fileconfignameDataAccess().GetDataForDropDown(cnf_fileconfigname, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_fileconfignameEntity> Icnf_fileconfignameFacade.GetDataForDropDown"));
            }
        }
        #endregion


        #endregion
    }
}