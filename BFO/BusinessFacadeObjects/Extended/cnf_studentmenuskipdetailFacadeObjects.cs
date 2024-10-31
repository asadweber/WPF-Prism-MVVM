
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
    public sealed partial class cnf_studentmenuskipdetailFacadeObjects
    {
		
       async Task<long> Icnf_studentmenuskipdetailFacadeObjects.AddExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().AddExt(cnf_studentmenuskipdetail, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_studentmenuskipdetailFacade.Addcnf_studentmenuskipdetail"));
            }
		}
       
		async Task<IList<cnf_studentmenuskipdetailEntity>> Icnf_studentmenuskipdetailFacadeObjects.GetAllExt(cnf_studentmenuskipdetailEntity cnf_studentmenuskipdetail, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_studentmenuskipdetailDataAccess().GetAllExt(cnf_studentmenuskipdetail, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_studentmenuskipdetailEntity> Icnf_studentmenuskipdetailFacade.GetAllcnf_studentmenuskipdetail"));
            }
		}
        
	}
}