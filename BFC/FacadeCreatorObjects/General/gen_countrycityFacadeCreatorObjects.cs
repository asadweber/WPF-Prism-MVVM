

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_countrycityFCC
    { 
	
		public gen_countrycityFCC()
        {
		
        }
		
		public static Igen_countrycityFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_countrycityFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_countrycityFacadeObjects"] as Igen_countrycityFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_countrycityFacadeObjects();
                    context.Items["Igen_countrycityFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_countrycityFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}