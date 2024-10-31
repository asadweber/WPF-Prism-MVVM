

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_statusFCC
    { 
	
		public gen_statusFCC()
        {
		
        }
		
		public static Igen_statusFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_statusFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_statusFacadeObjects"] as Igen_statusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_statusFacadeObjects();
                    context.Items["Igen_statusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_statusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}