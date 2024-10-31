

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_newscategoryFCC
    { 
	
		public gen_newscategoryFCC()
        {
		
        }
		
		public static Igen_newscategoryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_newscategoryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_newscategoryFacadeObjects"] as Igen_newscategoryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_newscategoryFacadeObjects();
                    context.Items["Igen_newscategoryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_newscategoryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}