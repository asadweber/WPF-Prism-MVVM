
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
    public sealed partial class cnf_studentmenuskipFacadeObjects
    {
		
       async Task<long> Icnf_studentmenuskipFacadeObjects.AddExt(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().AddExt(cnf_studentmenuskip, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipFacade.Addcnf_studentmenuskip"));
            }
		}
       
		async Task<IList<cnf_studentmenuskipEntity>> Icnf_studentmenuskipFacadeObjects.GetAllExt(cnf_studentmenuskipEntity cnf_studentmenuskip, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipDataAccess().GetAllExt(cnf_studentmenuskip, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipEntity> Icnf_studentmenuskipFacade.GetAllcnf_studentmenuskip"));
            }
		}
        
	}
}