

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_newsFCC
    { 
	
		public gen_newsFCC()
        {
		
        }
		
		public static Igen_newsFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_newsFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_newsFacadeObjects"] as Igen_newsFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_newsFacadeObjects();
                    context.Items["Igen_newsFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_newsFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}