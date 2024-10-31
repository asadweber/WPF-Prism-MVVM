

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_serviceinfoFCC
    { 
	
		public gen_serviceinfoFCC()
        {
		
        }
		
		public static Igen_serviceinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_serviceinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_serviceinfoFacadeObjects"] as Igen_serviceinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_serviceinfoFacadeObjects();
                    context.Items["Igen_serviceinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_serviceinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}