
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
    public sealed partial class gen_educationmajorFacadeObjects : BaseFacade, Igen_educationmajorFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_educationmajorFacadeObjects";
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

        public gen_educationmajorFacadeObjects()
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

        ~gen_educationmajorFacadeObjects()
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
		
		async Task<long> Igen_educationmajorFacadeObjects.Delete(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_educationmajorDataAccess().Delete(gen_educationmajor, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationmajorFacade.Deletegen_educationmajor"));
            }
        }
		
		async Task<long> Igen_educationmajorFacadeObjects.Update(gen_educationmajorEntity gen_educationmajor , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().Update(gen_educationmajor,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_educationmajorFacade.Updategen_educationmajor"));
            }
		}
		
		async Task<long> Igen_educationmajorFacadeObjects.Add(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().Add(gen_educationmajor, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationmajorFacade.Addgen_educationmajor"));
            }
		}
		
        async Task<long> Igen_educationmajorFacadeObjects.SaveList(List<gen_educationmajorEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_educationmajorEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_educationmajorEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_educationmajorEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_educationmajorDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_educationmajor"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_educationmajorEntity>> Igen_educationmajorFacadeObjects.GetAll(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().GetAll(gen_educationmajor, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationmajorEntity> Igen_educationmajorFacade.GetAllgen_educationmajor"));
            }
		}
		
		async Task<IList<gen_educationmajorEntity>> Igen_educationmajorFacadeObjects.GetAllByPages(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().GetAllByPages(gen_educationmajor,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationmajorEntity> Igen_educationmajorFacade.GetAllByPagesgen_educationmajor"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_educationmajorFacadeObjects.SaveMasterDetreg_educationinfo(gen_educationmajorEntity Master, List<reg_educationinfoEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_educationmajorDataAccess().SaveMasterDetreg_educationinfo(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_educationinfo"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_educationmajorEntity>  Igen_educationmajorFacadeObjects.GetSingle(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().GetSingle(gen_educationmajor,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_educationmajorEntity Igen_educationmajorFacade.GetSinglegen_educationmajor"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_educationmajorEntity>> Igen_educationmajorFacadeObjects.GAPgListView(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().GAPgListView(gen_educationmajor,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationmajorEntity> Igen_educationmajorFacade.GAPgListViewgen_educationmajor"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_educationmajorFacadeObjects.GetDataForDropDown(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().GetDataForDropDown(gen_educationmajor,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_educationmajorEntity> Igen_educationmajorFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}