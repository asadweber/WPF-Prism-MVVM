
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
    public sealed partial class gen_instituteinfoFacadeObjects
    {
		
       async Task<long> Igen_instituteinfoFacadeObjects.AddExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().AddExt(gen_instituteinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_instituteinfoFacade.Addgen_instituteinfo"));
            }
		}

        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoFacadeObjects.GetAllExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_instituteinfoDataAccess().GetAllExt(gen_instituteinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_instituteinfoFacade.Addgen_instituteinfo"));
            }
        }

        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoFacadeObjects.GetInstituteInfoDataForDropDown(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_instituteinfoDataAccess().GetInstituteInfoDataForDropDown(gen_instituteinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_instituteinfoEntity> Igen_instituteinfoFacade.GetInstituteInfoDataForDropDown"));
            }
		}

        async Task<IList<gen_instituteinfoEntity>> Igen_instituteinfoFacadeObjects.GAPgListViewExt(gen_instituteinfoEntity gen_instituteinfo, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_instituteinfoDataAccess().GAPgListViewExt(gen_instituteinfo, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_instituteinfoEntity> Igen_instituteinfoFacade.GAPgListViewExtgen_instituteinfo"));
            }
        }


    }
}