

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_servicestypeFCC
    { 
	
		public gen_servicestypeFCC()
        {
		
        }
		
		public static Igen_servicestypeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_servicestypeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_servicestypeFacadeObjects"] as Igen_servicestypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_servicestypeFacadeObjects();
                    context.Items["Igen_servicestypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_servicestypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}