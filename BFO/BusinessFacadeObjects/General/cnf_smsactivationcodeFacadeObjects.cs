
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
    public sealed partial class cnf_smsactivationcodeFacadeObjects : BaseFacade, Icnf_smsactivationcodeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_smsactivationcodeFacadeObjects";
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

        public cnf_smsactivationcodeFacadeObjects()
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

        ~cnf_smsactivationcodeFacadeObjects()
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
		
		async Task<long> Icnf_smsactivationcodeFacadeObjects.Delete(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().Delete(cnf_smsactivationcode, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationcodeFacade.Deletecnf_smsactivationcode"));
            }
        }
		
		async Task<long> Icnf_smsactivationcodeFacadeObjects.Update(cnf_smsactivationcodeEntity cnf_smsactivationcode , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().Update(cnf_smsactivationcode,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationcodeFacade.Updatecnf_smsactivationcode"));
            }
		}
		
		async Task<long> Icnf_smsactivationcodeFacadeObjects.Add(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().Add(cnf_smsactivationcode, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationcodeFacade.Addcnf_smsactivationcode"));
            }
		}
		
        async Task<long> Icnf_smsactivationcodeFacadeObjects.SaveList(List<cnf_smsactivationcodeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_smsactivationcodeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_smsactivationcodeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_smsactivationcodeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_smsactivationcode"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeFacadeObjects.GetAll(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().GetAll(cnf_smsactivationcode, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacade.GetAllcnf_smsactivationcode"));
            }
		}
		
		async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeFacadeObjects.GetAllByPages(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().GetAllByPages(cnf_smsactivationcode,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacade.GetAllByPagescnf_smsactivationcode"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Icnf_smsactivationcodeFacadeObjects.SaveMasterDetcnf_smsactivationtransection(cnf_smsactivationcodeEntity Master, List<cnf_smsactivationtransectionEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<cnf_smsactivationtransectionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<cnf_smsactivationtransectionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<cnf_smsactivationtransectionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().SaveMasterDetcnf_smsactivationtransection(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetcnf_smsactivationtransection"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_smsactivationcodeEntity>  Icnf_smsactivationcodeFacadeObjects.GetSingle(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().GetSingle(cnf_smsactivationcode,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_smsactivationcodeEntity Icnf_smsactivationcodeFacade.GetSinglecnf_smsactivationcode"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_smsactivationcodeEntity>> Icnf_smsactivationcodeFacadeObjects.GAPgListView(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().GAPgListView(cnf_smsactivationcode,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacade.GAPgListViewcnf_smsactivationcode"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Icnf_smsactivationcodeFacadeObjects.GetDataForDropDown(cnf_smsactivationcodeEntity cnf_smsactivationcode, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationcodeDataAccess().GetDataForDropDown(cnf_smsactivationcode,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationcodeEntity> Icnf_smsactivationcodeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}