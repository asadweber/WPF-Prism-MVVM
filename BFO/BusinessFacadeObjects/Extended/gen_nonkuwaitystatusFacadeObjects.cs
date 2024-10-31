
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
    public sealed partial class gen_nonkuwaitystatusFacadeObjects
    {
		
       async Task<long> Igen_nonkuwaitystatusFacadeObjects.AddExt(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().AddExt(gen_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_nonkuwaitystatusFacade.Addgen_nonkuwaitystatus"));
            }
		}
       
		async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusFacadeObjects.GetAllExt(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GetAllExt(gen_nonkuwaitystatus, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusFacade.GetAllgen_nonkuwaitystatus"));
            }
		}

        async Task<IList<gen_nonkuwaitystatusEntity>> Igen_nonkuwaitystatusFacadeObjects.GetAllByGroup(gen_nonkuwaitystatusEntity gen_nonkuwaitystatus, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Creategen_nonkuwaitystatusDataAccess().GetAllByGroup(gen_nonkuwaitystatus, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_nonkuwaitystatusEntity> Igen_nonkuwaitystatusFacade.GetAllgen_nonkuwaitystatus"));
            }
        }

    }
}