
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
    public sealed partial class tran_applicantphasesFacadeObjects
    {
		
       async Task<long> Itran_applicantphasesFacadeObjects.AddExt(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().AddExt(tran_applicantphases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_applicantphasesFacade.Addtran_applicantphases"));
            }
		}
       
		async Task<IList<tran_applicantphasesEntity>> Itran_applicantphasesFacadeObjects.GetAllExt(tran_applicantphasesEntity tran_applicantphases, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_applicantphasesDataAccess().GetAllExt(tran_applicantphases, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_applicantphasesEntity> Itran_applicantphasesFacade.GetAlltran_applicantphases"));
            }
		}
        
	}
}