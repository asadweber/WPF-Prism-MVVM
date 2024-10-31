

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_candidatetypeFCC
    { 
	
		public gen_candidatetypeFCC()
        {
		
        }
		
		public static Igen_candidatetypeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_candidatetypeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_candidatetypeFacadeObjects"] as Igen_candidatetypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_candidatetypeFacadeObjects();
                    context.Items["Igen_candidatetypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_candidatetypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}