
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
    public sealed partial class gen_religionFacadeObjects
    {
		
       async Task<long> Igen_religionFacadeObjects.AddExt(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().AddExt(gen_religion, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_religionFacade.Addgen_religion"));
            }
		}
       
		async Task<IList<gen_religionEntity>> Igen_religionFacadeObjects.GetAllExt(gen_religionEntity gen_religion, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_religionDataAccess().GetAllExt(gen_religion, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> Igen_religionFacade.GetAllgen_religion"));
            }
		}

        async Task<IList<gen_religionEntity>> Igen_religionFacadeObjects.GetReligionDataForDropDown(gen_religionEntity gen_religion, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_religionDataAccess().GetReligionDataForDropDown(gen_religion, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_religionEntity> Igen_religionFacade.GetReligionDataForDropDown"));
            }
        }


        

    }
}