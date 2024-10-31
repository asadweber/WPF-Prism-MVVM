

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_educationgradeFCC
    { 
	
		public gen_educationgradeFCC()
        {
		
        }
		
		public static Igen_educationgradeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_educationgradeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_educationgradeFacadeObjects"] as Igen_educationgradeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_educationgradeFacadeObjects();
                    context.Items["Igen_educationgradeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_educationgradeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}