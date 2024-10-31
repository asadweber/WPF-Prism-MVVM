

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_educationmajorFCC
    { 
	
		public gen_educationmajorFCC()
        {
		
        }
		
		public static Igen_educationmajorFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_educationmajorFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_educationmajorFacadeObjects"] as Igen_educationmajorFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_educationmajorFacadeObjects();
                    context.Items["Igen_educationmajorFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_educationmajorFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}