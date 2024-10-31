

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_companiesFCC
    { 
	
		public gen_companiesFCC()
        {
		
        }
		
		public static Igen_companiesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_companiesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_companiesFacadeObjects"] as Igen_companiesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_companiesFacadeObjects();
                    context.Items["Igen_companiesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_companiesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}