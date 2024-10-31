

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_applyanotherbatchFCC
    { 
	
		public tran_applyanotherbatchFCC()
        {
		
        }
		
		public static Itran_applyanotherbatchFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_applyanotherbatchFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_applyanotherbatchFacadeObjects"] as Itran_applyanotherbatchFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_applyanotherbatchFacadeObjects();
                    context.Items["Itran_applyanotherbatchFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_applyanotherbatchFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}