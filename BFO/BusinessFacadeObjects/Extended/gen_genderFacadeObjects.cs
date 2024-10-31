
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
    public sealed partial class gen_genderFacadeObjects
    {
		
       async Task<long> Igen_genderFacadeObjects.AddExt(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().AddExt(gen_gender, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_genderFacade.Addgen_gender"));
            }
		}
       
		async Task<IList<gen_genderEntity>> Igen_genderFacadeObjects.GetAllExt(gen_genderEntity gen_gender, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_genderDataAccess().GetAllExt(gen_gender, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_genderEntity> Igen_genderFacade.GetAllgen_gender"));
            }
		}
        
	}
}