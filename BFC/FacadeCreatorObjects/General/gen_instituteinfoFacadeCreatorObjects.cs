

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_instituteinfoFCC
    { 
	
		public gen_instituteinfoFCC()
        {
		
        }
		
		public static Igen_instituteinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_instituteinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_instituteinfoFacadeObjects"] as Igen_instituteinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_instituteinfoFacadeObjects();
                    context.Items["Igen_instituteinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_instituteinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}