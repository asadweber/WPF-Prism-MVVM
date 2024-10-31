
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
    public sealed partial class gen_trainingcentreFacadeObjects : BaseFacade, Igen_trainingcentreFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_trainingcentreFacadeObjects";
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

        public gen_trainingcentreFacadeObjects()
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

        ~gen_trainingcentreFacadeObjects()
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
		
		async Task<long> Igen_trainingcentreFacadeObjects.Delete(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().Delete(gen_trainingcentre, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_trainingcentreFacade.Deletegen_trainingcentre"));
            }
        }
		
		async Task<long> Igen_trainingcentreFacadeObjects.Update(gen_trainingcentreEntity gen_trainingcentre , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().Update(gen_trainingcentre,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_trainingcentreFacade.Updategen_trainingcentre"));
            }
		}
		
		async Task<long> Igen_trainingcentreFacadeObjects.Add(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().Add(gen_trainingcentre, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_trainingcentreFacade.Addgen_trainingcentre"));
            }
		}
		
        async Task<long> Igen_trainingcentreFacadeObjects.SaveList(List<gen_trainingcentreEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_trainingcentreEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_trainingcentreEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_trainingcentreEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_trainingcentreDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_trainingcentre"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_trainingcentreEntity>> Igen_trainingcentreFacadeObjects.GetAll(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().GetAll(gen_trainingcentre, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_trainingcentreEntity> Igen_trainingcentreFacade.GetAllgen_trainingcentre"));
            }
		}
		
		async Task<IList<gen_trainingcentreEntity>> Igen_trainingcentreFacadeObjects.GetAllByPages(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().GetAllByPages(gen_trainingcentre,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_trainingcentreEntity> Igen_trainingcentreFacade.GetAllByPagesgen_trainingcentre"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_trainingcentreFacadeObjects.SaveMasterDettran_trainingjoin(gen_trainingcentreEntity Master, List<tran_trainingjoinEntity> DetailList, CancellationToken cancellationToken)
        {
            try
               {
                    DetailList.ForEach(P => P.BaseSecurityParam = new SecurityCapsule());
                    DetailList.ForEach(P => P.BaseSecurityParam = Master.BaseSecurityParam);
                    if (Master.CurrentState == BaseEntity.EntityState.Deleted)
						DetailList.ForEach(p => p.CurrentState = BaseEntity.EntityState.Deleted);
                    IList<tran_trainingjoinEntity> listAdded = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                    IList<tran_trainingjoinEntity> listUpdated = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                    IList<tran_trainingjoinEntity> listDeleted = DetailList.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
                    return await DataAccessFactory.Creategen_trainingcentreDataAccess().SaveMasterDettran_trainingjoin(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDettran_trainingjoin"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_trainingcentreEntity>  Igen_trainingcentreFacadeObjects.GetSingle(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().GetSingle(gen_trainingcentre,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_trainingcentreEntity Igen_trainingcentreFacade.GetSinglegen_trainingcentre"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_trainingcentreEntity>> Igen_trainingcentreFacadeObjects.GAPgListView(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().GAPgListView(gen_trainingcentre,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_trainingcentreEntity> Igen_trainingcentreFacade.GAPgListViewgen_trainingcentre"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_trainingcentreFacadeObjects.GetDataForDropDown(gen_trainingcentreEntity gen_trainingcentre, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_trainingcentreDataAccess().GetDataForDropDown(gen_trainingcentre,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_trainingcentreEntity> Igen_trainingcentreFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}