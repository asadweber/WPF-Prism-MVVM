

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_usefullinkFCC
    { 
	
		public gen_usefullinkFCC()
        {
		
        }
		
		public static Igen_usefullinkFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_usefullinkFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_usefullinkFacadeObjects"] as Igen_usefullinkFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_usefullinkFacadeObjects();
                    context.Items["Igen_usefullinkFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_usefullinkFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}