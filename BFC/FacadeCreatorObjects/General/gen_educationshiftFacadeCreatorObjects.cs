

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_educationshiftFCC
    { 
	
		public gen_educationshiftFCC()
        {
		
        }
		
		public static Igen_educationshiftFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_educationshiftFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_educationshiftFacadeObjects"] as Igen_educationshiftFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_educationshiftFacadeObjects();
                    context.Items["Igen_educationshiftFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_educationshiftFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}