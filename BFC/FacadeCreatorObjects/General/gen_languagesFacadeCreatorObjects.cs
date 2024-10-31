

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_languagesFCC
    { 
	
		public gen_languagesFCC()
        {
		
        }
		
		public static Igen_languagesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_languagesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_languagesFacadeObjects"] as Igen_languagesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_languagesFacadeObjects();
                    context.Items["Igen_languagesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_languagesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}