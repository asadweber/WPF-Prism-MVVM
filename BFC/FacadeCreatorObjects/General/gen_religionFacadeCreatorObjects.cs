

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_religionFCC
    { 
	
		public gen_religionFCC()
        {
		
        }
		
		public static Igen_religionFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_religionFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_religionFacadeObjects"] as Igen_religionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_religionFacadeObjects();
                    context.Items["Igen_religionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_religionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}