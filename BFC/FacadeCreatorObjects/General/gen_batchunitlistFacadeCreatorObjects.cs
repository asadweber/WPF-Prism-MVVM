

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_batchunitlistFCC
    { 
	
		public gen_batchunitlistFCC()
        {
		
        }
		
		public static Igen_batchunitlistFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_batchunitlistFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_batchunitlistFacadeObjects"] as Igen_batchunitlistFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_batchunitlistFacadeObjects();
                    context.Items["Igen_batchunitlistFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_batchunitlistFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}