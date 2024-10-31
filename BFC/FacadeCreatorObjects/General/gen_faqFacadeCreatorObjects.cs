

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_faqFCC
    { 
	
		public gen_faqFCC()
        {
		
        }
		
		public static Igen_faqFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_faqFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_faqFacadeObjects"] as Igen_faqFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_faqFacadeObjects();
                    context.Items["Igen_faqFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_faqFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}