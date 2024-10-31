
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
    public sealed partial class gen_relationshipFacadeObjects
    {
		
       async Task<long> Igen_relationshipFacadeObjects.AddExt(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().AddExt(gen_relationship, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("Igen_relationshipFacade.Addgen_relationship"));
            }
		}
       
		async Task<IList<gen_relationshipEntity>> Igen_relationshipFacadeObjects.GetAllExt(gen_relationshipEntity gen_relationship, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_relationshipDataAccess().GetAllExt(gen_relationship, cancellationToken);
			}
           
            catch (Exception ex)
            {
                throw GetFacadeException(ex, SourceOfException("IList<gen_relationshipEntity> Igen_relationshipFacade.GetAllgen_relationship"));
            }
		}
        
	}
}