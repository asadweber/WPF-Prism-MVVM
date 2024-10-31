
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
    public sealed partial class tran_exportprofileFacadeObjects
    {
		
       async Task<long> Itran_exportprofileFacadeObjects.AddExt(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().AddExt(tran_exportprofile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_exportprofileFacade.Addtran_exportprofile"));
            }
		}
       
		async Task<IList<tran_exportprofileEntity>> Itran_exportprofileFacadeObjects.GetAllExt(tran_exportprofileEntity tran_exportprofile, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_exportprofileDataAccess().GetAllExt(tran_exportprofile, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_exportprofileEntity> Itran_exportprofileFacade.GetAlltran_exportprofile"));
            }
		}
        
	}
}