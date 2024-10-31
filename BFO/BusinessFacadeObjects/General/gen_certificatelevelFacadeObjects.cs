
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
    public sealed partial class gen_certificatelevelFacadeObjects : BaseFacade, Igen_certificatelevelFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_certificatelevelFacadeObjects";
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

        public gen_certificatelevelFacadeObjects()
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

        ~gen_certificatelevelFacadeObjects()
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
		
		async Task<long> Igen_certificatelevelFacadeObjects.Delete(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().Delete(gen_certificatelevel, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatelevelFacade.Deletegen_certificatelevel"));
            }
        }
		
		async Task<long> Igen_certificatelevelFacadeObjects.Update(gen_certificatelevelEntity gen_certificatelevel , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().Update(gen_certificatelevel,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_certificatelevelFacade.Updategen_certificatelevel"));
            }
		}
		
		async Task<long> Igen_certificatelevelFacadeObjects.Add(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().Add(gen_certificatelevel, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatelevelFacade.Addgen_certificatelevel"));
            }
		}
		
        async Task<long> Igen_certificatelevelFacadeObjects.SaveList(List<gen_certificatelevelEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_certificatelevelEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_certificatelevelEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_certificatelevelEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_certificatelevelDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_certificatelevel"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelFacadeObjects.GetAll(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().GetAll(gen_certificatelevel, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatelevelEntity> Igen_certificatelevelFacade.GetAllgen_certificatelevel"));
            }
		}
		
		async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelFacadeObjects.GetAllByPages(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().GetAllByPages(gen_certificatelevel,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatelevelEntity> Igen_certificatelevelFacade.GetAllByPagesgen_certificatelevel"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_certificatelevelFacadeObjects.SaveMasterDetgen_batchcandidatecertificate(gen_certificatelevelEntity Master, List<gen_batchcandidatecertificateEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_certificatelevelDataAccess().SaveMasterDetgen_batchcandidatecertificate(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandidatecertificate"));
               }
        }
        
        
        async Task<long> Igen_certificatelevelFacadeObjects.SaveMasterDetgen_certificate(gen_certificatelevelEntity Master, List<gen_certificateEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_certificateEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_certificateEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_certificateEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_certificatelevelDataAccess().SaveMasterDetgen_certificate(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_certificate"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_certificatelevelEntity>  Igen_certificatelevelFacadeObjects.GetSingle(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().GetSingle(gen_certificatelevel,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_certificatelevelEntity Igen_certificatelevelFacade.GetSinglegen_certificatelevel"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelFacadeObjects.GAPgListView(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().GAPgListView(gen_certificatelevel,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatelevelEntity> Igen_certificatelevelFacade.GAPgListViewgen_certificatelevel"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_certificatelevelFacadeObjects.GetDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().GetDataForDropDown(gen_certificatelevel,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_certificatelevelEntity> Igen_certificatelevelFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}