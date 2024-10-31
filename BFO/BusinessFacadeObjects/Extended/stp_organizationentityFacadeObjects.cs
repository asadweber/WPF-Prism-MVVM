
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
    public sealed partial class stp_organizationentityFacadeObjects
    {
		
       async Task<long> Istp_organizationentityFacadeObjects.AddExt(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().AddExt(stp_organizationentity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentityFacade.Addstp_organizationentity"));
            }
		}
       
		async Task<IList<stp_organizationentityEntity>> Istp_organizationentityFacadeObjects.GetAllExt(stp_organizationentityEntity stp_organizationentity, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentityDataAccess().GetAllExt(stp_organizationentity, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentityEntity> Istp_organizationentityFacade.GetAllstp_organizationentity"));
            }
		}
        
	}
}