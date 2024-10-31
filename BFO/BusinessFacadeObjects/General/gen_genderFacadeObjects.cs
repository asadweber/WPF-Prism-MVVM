
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
    public sealed partial class gen_genderFacadeObjects : BaseFacade, Igen_genderFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_genderFacadeObjects";
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

        public gen_genderFacadeObjects()
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

        ~gen_genderFacadeObjects()
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
		
		async Task<long> Igen_genderFacadeObjects.Delete(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_genderDataAccess().Delete(gen_gender, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_genderFacade.Deletegen_gender"));
            }
        }
		
		async Task<long> Igen_genderFacadeObjects.Update(gen_genderEntity gen_gender , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().Update(gen_gender,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_genderFacade.Updategen_gender"));
            }
		}
		
		async Task<long> Igen_genderFacadeObjects.Add(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().Add(gen_gender, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_genderFacade.Addgen_gender"));
            }
		}
		
        async Task<long> Igen_genderFacadeObjects.SaveList(List<gen_genderEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_genderEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_genderEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_genderEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_genderDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_gender"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_genderEntity>> Igen_genderFacadeObjects.GetAll(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().GetAll(gen_gender, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_genderEntity> Igen_genderFacade.GetAllgen_gender"));
            }
		}
		
		async Task<IList<gen_genderEntity>> Igen_genderFacadeObjects.GetAllByPages(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().GetAllByPages(gen_gender,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_genderEntity> Igen_genderFacade.GetAllByPagesgen_gender"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_genderFacadeObjects.SaveMasterDetreg_familly(gen_genderEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_famillyEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_famillyEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_famillyEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_genderDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_genderEntity>  Igen_genderFacadeObjects.GetSingle(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().GetSingle(gen_gender,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_genderEntity Igen_genderFacade.GetSinglegen_gender"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_genderEntity>> Igen_genderFacadeObjects.GAPgListView(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().GAPgListView(gen_gender,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_genderEntity> Igen_genderFacade.GAPgListViewgen_gender"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_genderFacadeObjects.GetDataForDropDown(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().GetDataForDropDown(gen_gender,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_genderEntity> Igen_genderFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}