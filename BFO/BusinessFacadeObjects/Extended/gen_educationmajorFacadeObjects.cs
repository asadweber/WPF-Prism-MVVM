
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
    public sealed partial class gen_educationmajorFacadeObjects
    {
		
       async Task<long> Igen_educationmajorFacadeObjects.AddExt(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().AddExt(gen_educationmajor, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_educationmajorFacade.Addgen_educationmajor"));
            }
		}
       
		async Task<IList<gen_educationmajorEntity>> Igen_educationmajorFacadeObjects.GetAllExt(gen_educationmajorEntity gen_educationmajor, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_educationmajorDataAccess().GetAllExt(gen_educationmajor, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_educationmajorEntity> Igen_educationmajorFacade.GetAllgen_educationmajor"));
            }
		}
        
	}
}