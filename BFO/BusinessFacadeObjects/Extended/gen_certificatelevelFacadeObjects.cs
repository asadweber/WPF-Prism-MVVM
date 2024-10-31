
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
    public sealed partial class gen_certificatelevelFacadeObjects
    {
		
       async Task<long> Igen_certificatelevelFacadeObjects.AddExt(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().AddExt(gen_certificatelevel, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_certificatelevelFacade.Addgen_certificatelevel"));
            }
		}
       
		async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelFacadeObjects.GetAllExt(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_certificatelevelDataAccess().GetAllExt(gen_certificatelevel, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatelevelEntity> Igen_certificatelevelFacade.GetAllgen_certificatelevel"));
            }
		}


        async Task<IList<gen_certificatelevelEntity>> Igen_certificatelevelFacadeObjects.GetCertificateLevelDataForDropDown(gen_certificatelevelEntity gen_certificatelevel, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_certificatelevelDataAccess().GetCertificateLevelDataForDropDown(gen_certificatelevel, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_certificatelevelEntity> Igen_certificatelevelFacade.GetCertificateLevelDataForDropDown"));
            }
        }

    }
}