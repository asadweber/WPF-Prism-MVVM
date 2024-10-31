

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_servicestatusFCC
    { 
	
		public gen_servicestatusFCC()
        {
		
        }
		
		public static Igen_servicestatusFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_servicestatusFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_servicestatusFacadeObjects"] as Igen_servicestatusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_servicestatusFacadeObjects();
                    context.Items["Igen_servicestatusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_servicestatusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}