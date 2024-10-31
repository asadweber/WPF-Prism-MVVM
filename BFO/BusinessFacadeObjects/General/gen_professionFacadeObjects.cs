
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
    public sealed partial class gen_professionFacadeObjects : BaseFacade, Igen_professionFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_professionFacadeObjects";
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

        public gen_professionFacadeObjects()
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

        ~gen_professionFacadeObjects()
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
		
		async Task<long> Igen_professionFacadeObjects.Delete(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_professionDataAccess().Delete(gen_profession, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_professionFacade.Deletegen_profession"));
            }
        }
		
		async Task<long> Igen_professionFacadeObjects.Update(gen_professionEntity gen_profession , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().Update(gen_profession,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_professionFacade.Updategen_profession"));
            }
		}
		
		async Task<long> Igen_professionFacadeObjects.Add(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().Add(gen_profession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_professionFacade.Addgen_profession"));
            }
		}
		
        async Task<long> Igen_professionFacadeObjects.SaveList(List<gen_professionEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_professionEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_professionEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_professionEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_professionDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_profession"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetAll(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().GetAll(gen_profession, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetAllgen_profession"));
            }
		}
		
		async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GetAllByPages(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().GetAllByPages(gen_profession,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetAllByPagesgen_profession"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_professionFacadeObjects.SaveMasterDetgen_batchcandprofession(gen_professionEntity Master, List<gen_batchcandprofessionEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_professionDataAccess().SaveMasterDetgen_batchcandprofession(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_batchcandprofession"));
               }
        }
        
        
        async Task<long> Igen_professionFacadeObjects.SaveMasterDetreg_registrationinfo(gen_professionEntity Master, List<reg_registrationinfoEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_professionDataAccess().SaveMasterDetreg_registrationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_registrationinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_professionEntity>  Igen_professionFacadeObjects.GetSingle(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().GetSingle(gen_profession,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_professionEntity Igen_professionFacade.GetSinglegen_profession"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_professionEntity>> Igen_professionFacadeObjects.GAPgListView(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().GAPgListView(gen_profession,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GAPgListViewgen_profession"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_professionFacadeObjects.GetDataForDropDown(gen_professionEntity gen_profession, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_professionDataAccess().GetDataForDropDown(gen_profession,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_professionEntity> Igen_professionFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}