
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
    public sealed partial class gen_instituteinfoFacadeObjects : BaseFacade, Igen_instituteinfoFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_instituteinfoFacadeObjects";
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

        public gen_instituteinfoFacadeObjects()
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

        ~gen_instituteinfoFacadeObjects()
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
		
		async Task<long> Igen_instituteinfoFacadeObjects.Delete(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().Delete(gen_instituteinfo, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_instituteinfoFacade.Deletegen_instituteinfo"));
            }
        }
		
		async Task<long> Igen_instituteinfoFacadeObjects.Update(gen_instituteinfoEntity gen_instituteinfo , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().Update(gen_instituteinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_instituteinfoFacade.Updategen_instituteinfo"));
            }
		}
		
		async Task<long> Igen_instituteinfoFacadeObjects.Add(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().Add(gen_instituteinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_instituteinfoFacade.Addgen_instituteinfo"));
            }
		}
		
        async Task<long> Igen_instituteinfoFacadeObjects.SaveList(List<gen_instituteinfoEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_instituteinfoEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_instituteinfoEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_instituteinfoEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_instituteinfoDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_instituteinfo"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoFacadeObjects.GetAll(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().GetAll(gen_instituteinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_instituteinfoEntity> Igen_instituteinfoFacade.GetAllgen_instituteinfo"));
            }
		}
		
		async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoFacadeObjects.GetAllByPages(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().GetAllByPages(gen_instituteinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_instituteinfoEntity> Igen_instituteinfoFacade.GetAllByPagesgen_instituteinfo"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_instituteinfoFacadeObjects.SaveMasterDetreg_educationinfo(gen_instituteinfoEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<reg_educationinfoEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<reg_educationinfoEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<reg_educationinfoEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_instituteinfoDataAccess().SaveMasterDetreg_educationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_educationinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_instituteinfoEntity>  Igen_instituteinfoFacadeObjects.GetSingle(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().GetSingle(gen_instituteinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_instituteinfoEntity Igen_instituteinfoFacade.GetSinglegen_instituteinfo"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoFacadeObjects.GAPgListView(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().GAPgListView(gen_instituteinfo,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_instituteinfoEntity> Igen_instituteinfoFacade.GAPgListViewgen_instituteinfo"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_instituteinfoFacadeObjects.GetDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().GetDataForDropDown(gen_instituteinfo,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_instituteinfoEntity> Igen_instituteinfoFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}