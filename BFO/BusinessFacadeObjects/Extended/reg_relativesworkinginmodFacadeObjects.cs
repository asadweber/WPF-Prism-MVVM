
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
    public sealed partial class reg_relativesworkinginmodFacadeObjects
    {
		
       async Task<long> Ireg_relativesworkinginmodFacadeObjects.AddExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().AddExt(reg_relativesworkinginmod, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Ireg_relativesworkinginmodFacade.Addreg_relativesworkinginmod"));
            }
		}
       
		async Task<IList<reg_relativesworkinginmodEntity>> Ireg_relativesworkinginmodFacadeObjects.GetAllExt(reg_relativesworkinginmodEntity reg_relativesworkinginmod, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_relativesworkinginmodDataAccess().GetAllExt(reg_relativesworkinginmod, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<reg_relativesworkinginmodEntity> Ireg_relativesworkinginmodFacade.GetAllreg_relativesworkinginmod"));
            }
		}
        
	}
}