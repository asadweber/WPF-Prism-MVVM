

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_rankFCC
    { 
	
		public gen_rankFCC()
        {
		
        }
		
		public static Igen_rankFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_rankFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_rankFacadeObjects"] as Igen_rankFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_rankFacadeObjects();
                    context.Items["Igen_rankFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_rankFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}