
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
    public sealed partial class gen_batchcandidatetypemapFacadeObjects : BaseFacade, Igen_batchcandidatetypemapFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_batchcandidatetypemapFacadeObjects";
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

        public gen_batchcandidatetypemapFacadeObjects()
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

        ~gen_batchcandidatetypemapFacadeObjects()
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
		
		async Task<long> Igen_batchcandidatetypemapFacadeObjects.Delete(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().Delete(gen_batchcandidatetypemap, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatetypemapFacade.Deletegen_batchcandidatetypemap"));
            }
        }
		
		async Task<long> Igen_batchcandidatetypemapFacadeObjects.Update(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().Update(gen_batchcandidatetypemap,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatetypemapFacade.Updategen_batchcandidatetypemap"));
            }
		}
		
		async Task<long> Igen_batchcandidatetypemapFacadeObjects.Add(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().Add(gen_batchcandidatetypemap, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_batchcandidatetypemapFacade.Addgen_batchcandidatetypemap"));
            }
		}
		
        async Task<long> Igen_batchcandidatetypemapFacadeObjects.SaveList(List<gen_batchcandidatetypemapEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_batchcandidatetypemapEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_batchcandidatetypemapEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_batchcandidatetypemapEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_batchcandidatetypemap"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapFacadeObjects.GetAll(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetAll(gen_batchcandidatetypemap, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GetAllgen_batchcandidatetypemap"));
            }
		}
		
		async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapFacadeObjects.GetAllByPages(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetAllByPages(gen_batchcandidatetypemap,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GetAllByPagesgen_batchcandidatetypemap"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_batchcandidatetypemapFacadeObjects.SaveMasterDetgen_batchcandidatecertificate(gen_batchcandidatetypemapEntity Master, List<gen_batchcandidatecertificateEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().SaveMasterDetgen_batchcandidatecertificate(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandidatecertificate"));
               }
        }
        
        
        async Task<long> Igen_batchcandidatetypemapFacadeObjects.SaveMasterDetgen_batchcandidatereqfile(gen_batchcandidatetypemapEntity Master, List<gen_batchcandidatereqfileEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_batchcandidatereqfileEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_batchcandidatereqfileEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_batchcandidatereqfileEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().SaveMasterDetgen_batchcandidatereqfile(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandidatereqfile"));
               }
        }
        
        
        async Task<long> Igen_batchcandidatetypemapFacadeObjects.SaveMasterDetgen_batchcandprofession(gen_batchcandidatetypemapEntity Master, List<gen_batchcandprofessionEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_batchcandprofessionEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_batchcandprofessionEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_batchcandprofessionEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().SaveMasterDetgen_batchcandprofession(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandprofession"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_batchcandidatetypemapEntity>  Igen_batchcandidatetypemapFacadeObjects.GetSingle(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetSingle(gen_batchcandidatetypemap,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_batchcandidatetypemapEntity Igen_batchcandidatetypemapFacade.GetSinglegen_batchcandidatetypemap"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_batchcandidatetypemapEntity>> Igen_batchcandidatetypemapFacadeObjects.GAPgListView(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GAPgListView(gen_batchcandidatetypemap,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GAPgListViewgen_batchcandidatetypemap"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_batchcandidatetypemapFacadeObjects.GetDataForDropDown(gen_batchcandidatetypemapEntity gen_batchcandidatetypemap, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_batchcandidatetypemapDataAccess().GetDataForDropDown(gen_batchcandidatetypemap,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_batchcandidatetypemapEntity> Igen_batchcandidatetypemapFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}