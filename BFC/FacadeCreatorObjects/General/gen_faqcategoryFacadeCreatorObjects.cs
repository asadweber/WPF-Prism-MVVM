

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_faqcategoryFCC
    { 
	
		public gen_faqcategoryFCC()
        {
		
        }
		
		public static Igen_faqcategoryFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_faqcategoryFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_faqcategoryFacadeObjects"] as Igen_faqcategoryFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_faqcategoryFacadeObjects();
                    context.Items["Igen_faqcategoryFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_faqcategoryFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}