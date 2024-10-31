
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
    public sealed partial class stp_organizationentitytypeFacadeObjects
    {
		
       async Task<long> Istp_organizationentitytypeFacadeObjects.AddExt(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentitytypeDataAccess().AddExt(stp_organizationentitytype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Istp_organizationentitytypeFacade.Addstp_organizationentitytype"));
            }
		}
       
		async Task<IList<stp_organizationentitytypeEntity>> Istp_organizationentitytypeFacadeObjects.GetAllExt(stp_organizationentitytypeEntity stp_organizationentitytype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createstp_organizationentitytypeDataAccess().GetAllExt(stp_organizationentitytype, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<stp_organizationentitytypeEntity> Istp_organizationentitytypeFacade.GetAllstp_organizationentitytype"));
            }
		}
        
	}
}