
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
    public sealed partial class gen_certificatetypeFacadeObjects
    {
		
       async Task<long> Igen_certificatetypeFacadeObjects.AddExt(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().AddExt(gen_certificatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatetypeFacade.Addgen_certificatetype"));
            }
		}
       
		async Task<IList<gen_certificatetypeEntity>> Igen_certificatetypeFacadeObjects.GetAllExt(gen_certificatetypeEntity gen_certificatetype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatetypeDataAccess().GetAllExt(gen_certificatetype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatetypeEntity> Igen_certificatetypeFacade.GetAllgen_certificatetype"));
            }
		}
        
	}
}