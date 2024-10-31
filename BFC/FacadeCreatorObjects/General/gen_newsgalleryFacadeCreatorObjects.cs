

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_newsgalleryFCC
    { 
	
		public gen_newsgalleryFCC()
        {
		
        }
		
		public static Igen_newsgalleryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_newsgalleryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_newsgalleryFacadeObjects"] as Igen_newsgalleryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_newsgalleryFacadeObjects();
                    context.Items["Igen_newsgalleryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_newsgalleryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}
