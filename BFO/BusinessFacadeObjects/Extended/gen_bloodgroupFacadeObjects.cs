
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
    public sealed partial class gen_bloodgroupFacadeObjects
    {
		
       async Task<long> Igen_bloodgroupFacadeObjects.AddExt(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().AddExt(gen_bloodgroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_bloodgroupFacade.Addgen_bloodgroup"));
            }
		}
       
		async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupFacadeObjects.GetAllExt(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_bloodgroupDataAccess().GetAllExt(gen_bloodgroup, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetAllgen_bloodgroup"));
            }
		}


        async Task<IList<gen_bloodgroupEntity>> Igen_bloodgroupFacadeObjects.GetBloodGroupDataForDropDown(gen_bloodgroupEntity gen_bloodgroup, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_bloodgroupDataAccess().GetBloodGroupDataForDropDown(gen_bloodgroup, cancellationToken);
            }
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_bloodgroupEntity> Igen_bloodgroupFacade.GetBloodGroupDataForDropDown"));
            }
        }

    }
}