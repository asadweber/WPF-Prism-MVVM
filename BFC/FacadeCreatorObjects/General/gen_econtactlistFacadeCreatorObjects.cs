

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_econtactlistFCC
    { 
	
		public gen_econtactlistFCC()
        {
		
        }
		
		public static Igen_econtactlistFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_econtactlistFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_econtactlistFacadeObjects"] as Igen_econtactlistFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_econtactlistFacadeObjects();
                    context.Items["Igen_econtactlistFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_econtactlistFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}