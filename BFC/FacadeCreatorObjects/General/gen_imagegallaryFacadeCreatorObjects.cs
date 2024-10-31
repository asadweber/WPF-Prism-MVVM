

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_imagegallaryFCC
    { 
	
		public gen_imagegallaryFCC()
        {
		
        }
		
		public static Igen_imagegallaryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_imagegallaryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_imagegallaryFacadeObjects"] as Igen_imagegallaryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_imagegallaryFacadeObjects();
                    context.Items["Igen_imagegallaryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_imagegallaryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}