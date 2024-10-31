

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_usefullinkcategoryFCC
    { 
	
		public gen_usefullinkcategoryFCC()
        {
		
        }
		
		public static Igen_usefullinkcategoryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_usefullinkcategoryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_usefullinkcategoryFacadeObjects"] as Igen_usefullinkcategoryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_usefullinkcategoryFacadeObjects();
                    context.Items["Igen_usefullinkcategoryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_usefullinkcategoryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}