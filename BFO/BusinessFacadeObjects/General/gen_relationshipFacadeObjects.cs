
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
    public sealed partial class gen_relationshipFacadeObjects : BaseFacade, Igen_relationshipFacadeObjects
    {
	
		#region Instance Variables
		private string ClassName = "gen_relationshipFacadeObjects";
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

        public gen_relationshipFacadeObjects()
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

        ~gen_relationshipFacadeObjects()
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
		
		async Task<long> Igen_relationshipFacadeObjects.Delete(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_relationshipDataAccess().Delete(gen_relationship, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Deletegen_relationship"));
            }
        }
		
		async Task<long> Igen_relationshipFacadeObjects.Update(gen_relationshipEntity gen_relationship , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().Update(gen_relationship,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Updategen_relationship"));
            }
		}
		
		async Task<long> Igen_relationshipFacadeObjects.Add(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().Add(gen_relationship, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Addgen_relationship"));
            }
		}
		
        async Task<long> Igen_relationshipFacadeObjects.SaveList(List<gen_relationshipEntity> list, CancellationToken cancellationToken)
        {
            try
            {
                IList<gen_relationshipEntity> listAdded = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Added);
                IList<gen_relationshipEntity> listUpdated = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Changed);
                IList<gen_relationshipEntity> listDeleted = list.FindAll(Item => Item.CurrentState == BaseEntity.EntityState.Deleted);
               
                return await DataAccessFactory.Creategen_relationshipDataAccess().SaveList(listAdded, listUpdated, listDeleted, cancellationToken);
            }
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Imer_poFacade.Save_gen_relationship"));
            }
        }
        
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_relationshipEntity>> Igen_relationshipFacadeObjects.GetAll(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().GetAll(gen_relationship, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GetAllgen_relationship"));
            }
		}
		
		async Task<IList<gen_relationshipEntity>> Igen_relationshipFacadeObjects.GetAllByPages(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().GetAllByPages(gen_relationship,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GetAllByPagesgen_relationship"));
            }
		}
		
		#endregion GetAll
        
        #region FOR Master Details SAVE	
        
        async Task<long> Igen_relationshipFacadeObjects.SaveMasterDetreg_familly(gen_relationshipEntity Master, List<reg_famillyEntity> DetailList, CancellationToken cancellationToken)
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
                    return await DataAccessFactory.Creategen_relationshipDataAccess().SaveMasterDetreg_familly(Master, listAdded, listUpdated, listDeleted, cancellationToken);
               }
               catch (Exception ex)
               {
                    throw GetFacadeException(ex, SourceOfException("Imer_poFacade.SaveMasterDetreg_familly"));
               }
        }
        
        
        #endregion	
	
        
        #region Simple load Single Row
        async  Task<gen_relationshipEntity>  Igen_relationshipFacadeObjects.GetSingle(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().GetSingle(gen_relationship,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_relationshipEntity Igen_relationshipFacade.GetSinglegen_relationship"));
            }
		}
        #endregion 
         
        #region ForListView Paged Method
        async Task<IList<gen_relationshipEntity>> Igen_relationshipFacadeObjects.GAPgListView(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().GAPgListView(gen_relationship,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GAPgListViewgen_relationship"));
            }
		}
        #endregion
        
        #region Extras Reviewed, Published, Archived
        #endregion 
    
    
    
        #region for Dropdown 
		async Task<IList<gen_dropdownEntity>> Igen_relationshipFacadeObjects.GetDataForDropDown(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().GetDataForDropDown(gen_relationship,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}