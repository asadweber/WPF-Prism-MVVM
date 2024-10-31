

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_companytypeFCC
    { 
	
		public gen_companytypeFCC()
        {
		
        }
		
		public static Igen_companytypeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_companytypeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_companytypeFacadeObjects"] as Igen_companytypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_companytypeFacadeObjects();
                    context.Items["Igen_companytypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_companytypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}