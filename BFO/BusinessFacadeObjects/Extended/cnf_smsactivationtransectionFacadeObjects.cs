
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
    public sealed partial class cnf_smsactivationtransectionFacadeObjects
    {
		
       async Task<long> Icnf_smsactivationtransectionFacadeObjects.AddExt(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().AddExt(cnf_smsactivationtransection, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Icnf_smsactivationtransectionFacade.Addcnf_smsactivationtransection"));
            }
		}
       
		async Task<IList<cnf_smsactivationtransectionEntity>> Icnf_smsactivationtransectionFacadeObjects.GetAllExt(cnf_smsactivationtransectionEntity cnf_smsactivationtransection, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createcnf_smsactivationtransectionDataAccess().GetAllExt(cnf_smsactivationtransection, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<cnf_smsactivationtransectionEntity> Icnf_smsactivationtransectionFacade.GetAllcnf_smsactivationtransection"));
            }
		}
        
	}
}