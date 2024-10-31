
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
    public sealed partial class tran_rollbackinfoFacadeObjects
    {
		
       async Task<long> Itran_rollbackinfoFacadeObjects.AddExt(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().AddExt(tran_rollbackinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Itran_rollbackinfoFacade.Addtran_rollbackinfo"));
            }
		}
       
		async Task<IList<tran_rollbackinfoEntity>> Itran_rollbackinfoFacadeObjects.GetAllExt(tran_rollbackinfoEntity tran_rollbackinfo, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createtran_rollbackinfoDataAccess().GetAllExt(tran_rollbackinfo, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<tran_rollbackinfoEntity> Itran_rollbackinfoFacade.GetAlltran_rollbackinfo"));
            }
		}
        
	}
}