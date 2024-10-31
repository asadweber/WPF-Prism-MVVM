
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
    public sealed partial class cnf_smsactivationtransectionFacadeObjects : BaseFacade, Icnf_smsactivationtransectionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "cnf_smsactivationtransectionFacadeObjects";
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

        public cnf_smsactivationtransectionFacadeObjects()
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

        ~cnf_smsactivationtransectionFacadeObjects()
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
		
		async Task<long> Icnf_smsactivationtransectionFacadeObjects.Delete(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().Delete(cnf_smsactivationtransection, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationtransectionFacade.Deletecnf_smsactivationtransection"));
            }
        }
		
		async Task<long> Icnf_smsactivationtransectionFacadeObjects.Update(cnf_smsactivationtransectionEntity cnf_smsactivationtransection , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().Update(cnf_smsactivationtransection,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationtransectionFacade.Updatecnf_smsactivationtransection"));
            }
		}
		
		async Task<long> Icnf_smsactivationtransectionFacadeObjects.Add(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().Add(cnf_smsactivationtransection, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationtransectionFacade.Addcnf_smsactivationtransection"));
            }
		}
		
        async Task<long> Icnf_smsactivationtransectionFacadeObjects.SaveList(List<cnf_smsactivationtransectionEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<cnf_smsactivationtransectionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<cnf_smsactivationtransectionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<cnf_smsactivationtransectionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_cnf_smsactivationtransection"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionFacadeObjects.GetAll(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().GetAll(cnf_smsactivationtransection, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationtransectionEntity> Icnf_smsactivationtransectionFacade.GetAllcnf_smsactivationtransection"));
            }
		}
		
		async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionFacadeObjects.GetAllByPages(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().GetAllByPages(cnf_smsactivationtransection,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationtransectionEntity> Icnf_smsactivationtransectionFacade.GetAllByPagescnf_smsactivationtransection"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<cnf_smsactivationtransectionEntity>  Icnf_smsactivationtransectionFacadeObjects.GetSingle(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().GetSingle(cnf_smsactivationtransection,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("cnf_smsactivationtransectionEntity Icnf_smsactivationtransectionFacade.GetSinglecnf_smsactivationtransection"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionFacadeObjects.GAPgListView(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().GAPgListView(cnf_smsactivationtransection,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationtransectionEntity> Icnf_smsactivationtransectionFacade.GAPgListViewcnf_smsactivationtransection"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}