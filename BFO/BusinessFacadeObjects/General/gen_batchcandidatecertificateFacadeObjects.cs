
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
    public sealed partial class gen_batchcandidatecertificateFacadeObjects : BaseFacade, Igen_batchcandidatecertificateFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_batchcandidatecertificateFacadeObjects";
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

        public gen_batchcandidatecertificateFacadeObjects()
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

        ~gen_batchcandidatecertificateFacadeObjects()
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
		
		async Task<long> Igen_batchcandidatecertificateFacadeObjects.Delete(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().Delete(gen_batchcandidatecertificate, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatecertificateFacade.Deletegen_batchcandidatecertificate"));
            }
        }
		
		async Task<long> Igen_batchcandidatecertificateFacadeObjects.Update(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().Update(gen_batchcandidatecertificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatecertificateFacade.Updategen_batchcandidatecertificate"));
            }
		}
		
		async Task<long> Igen_batchcandidatecertificateFacadeObjects.Add(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().Add(gen_batchcandidatecertificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatecertificateFacade.Addgen_batchcandidatecertificate"));
            }
		}
		
        async Task<long> Igen_batchcandidatecertificateFacadeObjects.SaveList(List<gen_batchcandidatecertificateEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_batchcandidatecertificateEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_batchcandidatecertificateEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_batchcandidatecertificateEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_batchcandidatecertificate"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateFacadeObjects.GetAll(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GetAll(gen_batchcandidatecertificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateFacade.GetAllgen_batchcandidatecertificate"));
            }
		}
		
		async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateFacadeObjects.GetAllByPages(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GetAllByPages(gen_batchcandidatecertificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateFacade.GetAllByPagesgen_batchcandidatecertificate"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_batchcandidatecertificateEntity>  Igen_batchcandidatecertificateFacadeObjects.GetSingle(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GetSingle(gen_batchcandidatecertificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandidatecertificateEntity Igen_batchcandidatecertificateFacade.GetSinglegen_batchcandidatecertificate"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_batchcandidatecertificateEntity>> Igen_batchcandidatecertificateFacadeObjects.GAPgListView(gen_batchcandidatecertificateEntity gen_batchcandidatecertificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatecertificateDataAccess().GAPgListView(gen_batchcandidatecertificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatecertificateEntity> Igen_batchcandidatecertificateFacade.GAPgListViewgen_batchcandidatecertificate"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
            
        
    
    
        #endregion
	}
}