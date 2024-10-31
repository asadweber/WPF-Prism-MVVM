
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
    public sealed partial class tran_specialregistrationFacadeObjects
    {
		
       async Task<long> Itran_specialregistrationFacadeObjects.AddExt(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().AddExt(tran_specialregistration, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_specialregistrationFacade.Addtran_specialregistration"));
            }
		}
       
		async Task<IList<tran_specialregistrationEntity>> Itran_specialregistrationFacadeObjects.GetAllExt(tran_specialregistrationEntity tran_specialregistration, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_specialregistrationDataAccess().GetAllExt(tran_specialregistration, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_specialregistrationEntity> Itran_specialregistrationFacade.GetAlltran_specialregistration"));
            }
		}
        
	}
}