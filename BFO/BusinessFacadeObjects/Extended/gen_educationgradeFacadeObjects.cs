
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
    public sealed partial class gen_educationgradeFacadeObjects
    {
		
       async Task<long> Igen_educationgradeFacadeObjects.AddExt(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().AddExt(gen_educationgrade, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationgradeFacade.Addgen_educationgrade"));
            }
		}
       
		async Task<IList<gen_educationgradeEntity>> Igen_educationgradeFacadeObjects.GetAllExt(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationgradeDataAccess().GetAllExt(gen_educationgrade, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationgradeEntity> Igen_educationgradeFacade.GetAllgen_educationgrade"));
            }
		}

        async Task<IList<gen_educationgradeEntity>> Igen_educationgradeFacadeObjects.GetEducationGradeDataForDropDown(gen_educationgradeEntity gen_educationgrade, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_educationgradeDataAccess().GetEducationGradeDataForDropDown(gen_educationgrade, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationgradeEntity> Igen_educationgradeFacade.GetEducationGradeDataForDropDown"));
            }
        }


    }
}