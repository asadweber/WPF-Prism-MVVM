
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
    public sealed partial class stp_organizationFacadeObjects
    {
		
       async Task<long> Istp_organizationFacadeObjects.AddExt(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().AddExt(stp_organization, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationFacade.Addstp_organization"));
            }
		}
       
		async Task<IList<stp_organizationEntity>> Istp_organizationFacadeObjects.GetAllExt(stp_organizationEntity stp_organization, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationDataAccess().GetAllExt(stp_organization, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationEntity> Istp_organizationFacade.GetAllstp_organization"));
            }
		}
        
	}
}