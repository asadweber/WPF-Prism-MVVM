

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_professionFCC
    { 
	
		public gen_professionFCC()
        {
		
        }
		
		public static Igen_professionFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_professionFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_professionFacadeObjects"] as Igen_professionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_professionFacadeObjects();
                    context.Items["Igen_professionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_professionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}