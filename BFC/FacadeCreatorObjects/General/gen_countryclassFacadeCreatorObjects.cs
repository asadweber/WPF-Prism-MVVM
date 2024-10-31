

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_countryclassFCC
    { 
	
		public gen_countryclassFCC()
        {
		
        }
		
		public static Igen_countryclassFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_countryclassFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_countryclassFacadeObjects"] as Igen_countryclassFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_countryclassFacadeObjects();
                    context.Items["Igen_countryclassFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_countryclassFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}