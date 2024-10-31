

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_generalhealthFCC
    { 
	
		public gen_generalhealthFCC()
        {
		
        }
		
		public static Igen_generalhealthFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_generalhealthFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_generalhealthFacadeObjects"] as Igen_generalhealthFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_generalhealthFacadeObjects();
                    context.Items["Igen_generalhealthFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_generalhealthFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}