

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_civilworkplacesFCC
    { 
	
		public gen_civilworkplacesFCC()
        {
		
        }
		
		public static Igen_civilworkplacesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_civilworkplacesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_civilworkplacesFacadeObjects"] as Igen_civilworkplacesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_civilworkplacesFacadeObjects();
                    context.Items["Igen_civilworkplacesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_civilworkplacesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}