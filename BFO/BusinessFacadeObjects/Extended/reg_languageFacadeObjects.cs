
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
    public sealed partial class reg_languageFacadeObjects
    {
		
       async Task<long> Ireg_languageFacadeObjects.AddExt(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().AddExt(reg_language, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_languageFacade.Addreg_language"));
            }
		}
       
		async Task<IList<reg_languageEntity>> Ireg_languageFacadeObjects.GetAllExt(reg_languageEntity reg_language, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_languageDataAccess().GetAllExt(reg_language, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_languageEntity> Ireg_languageFacade.GetAllreg_language"));
            }
		}
        
	}
}