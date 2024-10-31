
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
    public sealed partial class gen_usefullinkFacadeObjects
    {
		
       async Task<long> Igen_usefullinkFacadeObjects.AddExt(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().AddExt(gen_usefullink, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_usefullinkFacade.Addgen_usefullink"));
            }
		}
       
		async Task<IList<gen_usefullinkEntity>> Igen_usefullinkFacadeObjects.GetAllExt(gen_usefullinkEntity gen_usefullink, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_usefullinkDataAccess().GetAllExt(gen_usefullink, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_usefullinkEntity> Igen_usefullinkFacade.GetAllgen_usefullink"));
            }
		}
        
	}
}