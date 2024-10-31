
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
    public sealed partial class cnf_fileconfignameFacadeObjects : BaseFacade, Icnf_fileconfignameFacadeObjects
    {
        async Task<IList<cnf_fileconfignameEntity>> Icnf_fileconfignameFacadeObjects.GetAllByBatchID(cnf_fileconfignameEntity cnf_fileconfigname, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_fileconfignameDataAccess().GetAllByBatchID(cnf_fileconfigname, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_fileconfignameEntity> Icnf_fileconfignameFacade.GetAllByBatchID"));
            }
        }
    }
}