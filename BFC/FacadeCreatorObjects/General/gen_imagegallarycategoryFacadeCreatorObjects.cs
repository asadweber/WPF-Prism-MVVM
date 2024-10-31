

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_imagegallarycategoryFCC
    { 
	
		public gen_imagegallarycategoryFCC()
        {
		
        }
		
		public static Igen_imagegallarycategoryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_imagegallarycategoryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_imagegallarycategoryFacadeObjects"] as Igen_imagegallarycategoryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_imagegallarycategoryFacadeObjects();
                    context.Items["Igen_imagegallarycategoryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_imagegallarycategoryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}