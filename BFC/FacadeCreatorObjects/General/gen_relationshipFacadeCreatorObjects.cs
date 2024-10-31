

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_relationshipFCC
    { 
	
		public gen_relationshipFCC()
        {
		
        }
		
		public static Igen_relationshipFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_relationshipFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_relationshipFacadeObjects"] as Igen_relationshipFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_relationshipFacadeObjects();
                    context.Items["Igen_relationshipFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_relationshipFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}