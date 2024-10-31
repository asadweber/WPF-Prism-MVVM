

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_certificatetypeFCC
    { 
	
		public gen_certificatetypeFCC()
        {
		
        }
		
		public static Igen_certificatetypeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_certificatetypeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_certificatetypeFacadeObjects"] as Igen_certificatetypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_certificatetypeFacadeObjects();
                    context.Items["Igen_certificatetypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_certificatetypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}