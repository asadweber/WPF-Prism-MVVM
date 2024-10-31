
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
    public sealed partial class gen_candidatetypeFacadeObjects : BaseFacade, Igen_candidatetypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_candidatetypeFacadeObjects";
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

        public gen_candidatetypeFacadeObjects()
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

        ~gen_candidatetypeFacadeObjects()
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
		
		async Task<long> Igen_candidatetypeFacadeObjects.Delete(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().Delete(gen_candidatetype, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_candidatetypeFacade.Deletegen_candidatetype"));
            }
        }
		
		async Task<long> Igen_candidatetypeFacadeObjects.Update(gen_candidatetypeEntity gen_candidatetype , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().Update(gen_candidatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_candidatetypeFacade.Updategen_candidatetype"));
            }
		}
		
		async Task<long> Igen_candidatetypeFacadeObjects.Add(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().Add(gen_candidatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_candidatetypeFacade.Addgen_candidatetype"));
            }
		}
		
        async Task<long> Igen_candidatetypeFacadeObjects.SaveList(List<gen_candidatetypeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_candidatetypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_candidatetypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_candidatetypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_candidatetypeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_candidatetype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GetAll(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetAll(gen_candidatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetAllgen_candidatetype"));
            }
		}
		
		async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GetAllByPages(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetAllByPages(gen_candidatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetAllByPagesgen_candidatetype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_candidatetypeFacadeObjects.SaveMasterDetgen_batchcandidatetypemap(gen_candidatetypeEntity Master, List<gen_batchcandidatetypemapEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<gen_batchcandidatetypemapEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<gen_batchcandidatetypemapEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<gen_batchcandidatetypemapEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_candidatetypeDataAccess().SaveMasterDetgen_batchcandidatetypemap(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandidatetypemap"));
               }
        }
        
        
        async Task<long> Igen_candidatetypeFacadeObjects.SaveMasterDetreg_registrationinfo(gen_candidatetypeEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_registrationinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_registrationinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_registrationinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_candidatetypeDataAccess().SaveMasterDetreg_registrationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_registrationinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_candidatetypeEntity>  Igen_candidatetypeFacadeObjects.GetSingle(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetSingle(gen_candidatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_candidatetypeEntity Igen_candidatetypeFacade.GetSinglegen_candidatetype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_candidatetypeEntity>> Igen_candidatetypeFacadeObjects.GAPgListView(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().GAPgListView(gen_candidatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GAPgListViewgen_candidatetype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_candidatetypeFacadeObjects.GetDataForDropDown(gen_candidatetypeEntity gen_candidatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_candidatetypeDataAccess().GetDataForDropDown(gen_candidatetype,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_candidatetypeEntity> Igen_candidatetypeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}