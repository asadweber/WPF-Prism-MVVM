
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
    public sealed partial class gen_certificateFacadeObjects : BaseFacade, Igen_certificateFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_certificateFacadeObjects";
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

        public gen_certificateFacadeObjects()
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

        ~gen_certificateFacadeObjects()
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
		
		async Task<long> Igen_certificateFacadeObjects.Delete(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_certificateDataAccess().Delete(gen_certificate, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificateFacade.Deletegen_certificate"));
            }
        }
		
		async Task<long> Igen_certificateFacadeObjects.Update(gen_certificateEntity gen_certificate , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().Update(gen_certificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_certificateFacade.Updategen_certificate"));
            }
		}
		
		async Task<long> Igen_certificateFacadeObjects.Add(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().Add(gen_certificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificateFacade.Addgen_certificate"));
            }
		}
		
        async Task<long> Igen_certificateFacadeObjects.SaveList(List<gen_certificateEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_certificateEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_certificateEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_certificateEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_certificateDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_certificate"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GetAll(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().GetAll(gen_certificate, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GetAllgen_certificate"));
            }
		}
		
		async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GetAllByPages(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().GetAllByPages(gen_certificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GetAllByPagesgen_certificate"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_certificateFacadeObjects.SaveMasterDetgen_batchcandidatecertificate(gen_certificateEntity Master, List<gen_batchcandidatecertificateEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_batchcandidatecertificateEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_batchcandidatecertificateEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_batchcandidatecertificateEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_certificateDataAccess().SaveMasterDetgen_batchcandidatecertificate(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandidatecertificate"));
               }
        }
        
        
        async Task<long> Igen_certificateFacadeObjects.SaveMasterDetgen_certificatesubjects(gen_certificateEntity Master, List<gen_certificatesubjectsEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_certificatesubjectsEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_certificatesubjectsEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_certificatesubjectsEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_certificateDataAccess().SaveMasterDetgen_certificatesubjects(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_certificatesubjects"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_certificateEntity>  Igen_certificateFacadeObjects.GetSingle(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().GetSingle(gen_certificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_certificateEntity Igen_certificateFacade.GetSinglegen_certificate"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_certificateEntity>> Igen_certificateFacadeObjects.GAPgListView(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().GAPgListView(gen_certificate,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GAPgListViewgen_certificate"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_certificateFacadeObjects.GetDataForDropDown(gen_certificateEntity gen_certificate, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificateDataAccess().GetDataForDropDown(gen_certificate,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_certificateEntity> Igen_certificateFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}