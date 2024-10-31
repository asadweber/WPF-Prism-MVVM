

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_professiongroupFCC
    { 
	
		public gen_professiongroupFCC()
        {
		
        }
		
		public static Igen_professiongroupFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_professiongroupFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_professiongroupFacadeObjects"] as Igen_professiongroupFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_professiongroupFacadeObjects();
                    context.Items["Igen_professiongroupFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_professiongroupFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}