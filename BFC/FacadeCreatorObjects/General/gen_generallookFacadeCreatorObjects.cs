

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_generallookFCC
    { 
	
		public gen_generallookFCC()
        {
		
        }
		
		public static Igen_generallookFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_generallookFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_generallookFacadeObjects"] as Igen_generallookFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_generallookFacadeObjects();
                    context.Items["Igen_generallookFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_generallookFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}