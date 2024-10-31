

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_countryFCC
    { 
	
		public gen_countryFCC()
        {
		
        }
		
		public static Igen_countryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_countryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_countryFacadeObjects"] as Igen_countryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_countryFacadeObjects();
                    context.Items["Igen_countryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_countryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}