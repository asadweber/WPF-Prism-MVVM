

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_certificateFCC
    { 
	
		public gen_certificateFCC()
        {
		
        }
		
		public static Igen_certificateFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_certificateFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_certificateFacadeObjects"] as Igen_certificateFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_certificateFacadeObjects();
                    context.Items["Igen_certificateFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_certificateFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}