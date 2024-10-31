
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
    public sealed partial class gen_newsFacadeObjects
    {
		#region Business Facade
		
		#region Save Update Delete List	
		
		async Task<long> Igen_newsFacadeObjects.Delete_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
            {
				return await DataAccessFactory.Creategen_newsDataAccess().Delete_Ext(gen_news, cancellationToken);
			}
            
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.Delete_Extgen_news"));
            }
        }
		
		async Task<long> Igen_newsFacadeObjects.Update_Ext(gen_newsEntity gen_news , CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().Update_Ext(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
               throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.Updategen_news"));
            }
		}
		
		async Task<long> Igen_newsFacadeObjects.Add_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().Add_Ext(gen_news, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newsFacade.Addgen_news"));
            }
		}
		
		#endregion Save Update Delete List	
		
		#region GetAll
		
		async Task<IList<gen_newsEntity>> Igen_newsFacadeObjects.GetAll_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().GetAll_Ext(gen_news, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newsEntity> Igen_newsFacade.GetAll_Extgen_news"));
            }
		}
		
		#endregion GetAll
        
        #region Simple load Single Row
        async  Task<gen_newsEntity>  Igen_newsFacadeObjects.GetSingle_Ext(gen_newsEntity gen_news, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newsDataAccess().GetSingle_Ext(gen_news,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("gen_newsEntity Igen_newsFacade.GetSingle_Extgen_news"));
            }
		}
        #endregion 
    
        #endregion
	}
}