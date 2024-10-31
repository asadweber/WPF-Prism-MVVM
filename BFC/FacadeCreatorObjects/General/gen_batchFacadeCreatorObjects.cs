

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_batchFCC
    { 
	
		public gen_batchFCC()
        {
		
        }
		
		public static Igen_batchFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_batchFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_batchFacadeObjects"] as Igen_batchFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_batchFacadeObjects();
                    context.Items["Igen_batchFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_batchFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}