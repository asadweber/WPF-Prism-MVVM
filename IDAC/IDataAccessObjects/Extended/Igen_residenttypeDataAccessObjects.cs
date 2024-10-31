using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace IDAC.Core.IDataAccessObjects.General
{
	public partial interface Igen_residenttypeDataAccessObjects
    {
        
        
        #region for Dropdown 
		Task<IList<gen_residenttypeEntity>> GetResidentTypeDataForDropDown(gen_residenttypeEntity gen_residenttype, CancellationToken cancellationToken); 
		#endregion
       
        
        
        
        
    }
}
