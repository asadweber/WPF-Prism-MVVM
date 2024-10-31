
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
    public sealed partial class gen_certificatetypeFacadeObjects : BaseFacade, Igen_certificatetypeFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_certificatetypeFacadeObjects";
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

        public gen_certificatetypeFacadeObjects()
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

        ~gen_certificatetypeFacadeObjects()
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
		
		async Task<long> Igen_certificatetypeFacadeObjects.Delete(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().Delete(gen_certificatetype, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatetypeFacade.Deletegen_certificatetype"));
            }
        }
		
		async Task<long> Igen_certificatetypeFacadeObjects.Update(gen_certificatetypeEntity gen_certificatetype , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().Update(gen_certificatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_certificatetypeFacade.Updategen_certificatetype"));
            }
		}
		
		async Task<long> Igen_certificatetypeFacadeObjects.Add(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().Add(gen_certificatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatetypeFacade.Addgen_certificatetype"));
            }
		}
		
        async Task<long> Igen_certificatetypeFacadeObjects.SaveList(List<gen_certificatetypeEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_certificatetypeEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_certificatetypeEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_certificatetypeEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_certificatetypeDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_certificatetype"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_certificatetypeEntity>> Igen_certificatetypeFacadeObjects.GetAll(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().GetAll(gen_certificatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatetypeEntity> Igen_certificatetypeFacade.GetAllgen_certificatetype"));
            }
		}
		
		async Task<IList<gen_certificatetypeEntity>> Igen_certificatetypeFacadeObjects.GetAllByPages(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().GetAllByPages(gen_certificatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatetypeEntity> Igen_certificatetypeFacade.GetAllByPagesgen_certificatetype"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_certificatetypeFacadeObjects.SaveMasterDetgen_certificate(gen_certificatetypeEntity Master, List<gen_certificateEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_certificatetypeDataAccess().SaveMasterDetgen_certificate(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetgen_certificate"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_certificatetypeEntity>  Igen_certificatetypeFacadeObjects.GetSingle(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().GetSingle(gen_certificatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_certificatetypeEntity Igen_certificatetypeFacade.GetSinglegen_certificatetype"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_certificatetypeEntity>> Igen_certificatetypeFacadeObjects.GAPgListView(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().GAPgListView(gen_certificatetype,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatetypeEntity> Igen_certificatetypeFacade.GAPgListViewgen_certificatetype"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_certificatetypeFacadeObjects.GetDataForDropDown(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().GetDataForDropDown(gen_certificatetype,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_certificatetypeEntity> Igen_certificatetypeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}