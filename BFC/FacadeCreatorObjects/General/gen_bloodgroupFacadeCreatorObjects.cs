

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_bloodgroupFCC
    { 
	
		public gen_bloodgroupFCC()
        {
		
        }
		
		public static Igen_bloodgroupFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_bloodgroupFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_bloodgroupFacadeObjects"] as Igen_bloodgroupFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_bloodgroupFacadeObjects();
                    context.Items["Igen_bloodgroupFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_bloodgroupFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}