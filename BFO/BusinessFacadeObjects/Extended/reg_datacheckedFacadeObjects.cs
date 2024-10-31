
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
    public sealed partial class reg_datacheckedFacadeObjects : BaseFacade, Ireg_datacheckedFacadeObjects
    {
	
        async  Task<reg_datacheckedEntity>  Ireg_datacheckedFacadeObjects.GetRegDataCheckedByBasicinfoRegistrationID(reg_datacheckedEntity reg_datachecked, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Createreg_datacheckedDataAccess().GetRegDataCheckedByBasicinfoRegistrationID(reg_datachecked,cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("reg_datacheckedEntity Ireg_datacheckedFacade.GetRegDataCheckedByBasicinfoRegistrationID"));
            }
		}
         
        
	}
}