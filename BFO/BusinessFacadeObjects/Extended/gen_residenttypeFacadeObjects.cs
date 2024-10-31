
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
    public sealed partial class gen_residenttypeFacadeObjects : BaseFacade, Igen_residenttypeFacadeObjects
    {
	
		
		#region Business Facade
		
		
    
        #region for Dropdown 
		async Task<IList<gen_residenttypeEntity>> Igen_residenttypeFacadeObjects.GetResidentTypeDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken)
		{
			try
			{
				return await DataAccessFactory.Creategen_residenttypeDataAccess().GetResidentTypeDataForDropDown(gen_residenttype,cancellationToken);
			}
			catch (Exception ex)
			{
				throw GetFacadeException(ex, SourceOfException("IList<gen_residenttypeEntity> Igen_residenttypeFacade.GetDataForDropDown")); 
			}
		}
		#endregion
    
        
    
    
        #endregion
	}
}