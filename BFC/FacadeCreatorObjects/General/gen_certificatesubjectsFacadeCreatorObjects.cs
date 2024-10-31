

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_certificatesubjectsFCC
    { 
	
		public gen_certificatesubjectsFCC()
        {
		
        }
		
		public static Igen_certificatesubjectsFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_certificatesubjectsFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_certificatesubjectsFacadeObjects"] as Igen_certificatesubjectsFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_certificatesubjectsFacadeObjects();
                    context.Items["Igen_certificatesubjectsFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_certificatesubjectsFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}