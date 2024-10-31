
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
    public sealed partial class gen_languagesFacadeObjects
    {
		
       async Task<long> Igen_languagesFacadeObjects.AddExt(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().AddExt(gen_languages, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_languagesFacade.Addgen_languages"));
            }
		}
       
		async Task<IList<gen_languagesEntity>> Igen_languagesFacadeObjects.GetAllExt(gen_languagesEntity gen_languages, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_languagesDataAccess().GetAllExt(gen_languages, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_languagesEntity> Igen_languagesFacade.GetAllgen_languages"));
            }
		}
        
	}
}