
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
    public sealed partial class gen_newscategoryFacadeObjects
    {
		
       async Task<long> Igen_newscategoryFacadeObjects.AddExt(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().AddExt(gen_newscategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_newscategoryFacade.Addgen_newscategory"));
            }
		}
       
		async Task<IList<gen_newscategoryEntity>> Igen_newscategoryFacadeObjects.GetAllExt(gen_newscategoryEntity gen_newscategory, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_newscategoryDataAccess().GetAllExt(gen_newscategory, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_newscategoryEntity> Igen_newscategoryFacade.GetAllgen_newscategory"));
            }
		}
        
	}
}