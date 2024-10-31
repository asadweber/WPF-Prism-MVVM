
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
    public sealed partial class cnf_filerequiredFacadeObjects
    {
		
       async Task<long> Icnf_filerequiredFacadeObjects.AddExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().AddExt(cnf_filerequired, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_filerequiredFacade.Addcnf_filerequired"));
            }
		}
       
		async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredFacadeObjects.GetAllExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_filerequiredDataAccess().GetAllExt(cnf_filerequired, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_filerequiredEntity> Icnf_filerequiredFacade.GetAllcnf_filerequired"));
            }
		}

        async Task<IList<cnf_filerequiredEntity>> Icnf_filerequiredFacadeObjects.GAPgListViewExt(cnf_filerequiredEntity cnf_filerequired, CancellationToken cancellationToken)
        {
            try
            {
                return await DataAccessFactory.Createcnf_filerequiredDataAccess().GAPgListViewExt(cnf_filerequired, cancellationToken);
            }

            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_filerequiredEntity> Icnf_filerequiredFacade.GAPgListViewExtcnf_filerequired"));
            }
        }

    }
}