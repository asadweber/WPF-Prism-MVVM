

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_residenttypeFCC
    { 
	
		public gen_residenttypeFCC()
        {
		
        }
		
		public static Igen_residenttypeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_residenttypeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_residenttypeFacadeObjects"] as Igen_residenttypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_residenttypeFacadeObjects();
                    context.Items["Igen_residenttypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_residenttypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}