

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_servicesFCC
    { 
	
		public gen_servicesFCC()
        {
		
        }
		
		public static Igen_servicesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_servicesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_servicesFacadeObjects"] as Igen_servicesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_servicesFacadeObjects();
                    context.Items["Igen_servicesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_servicesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}