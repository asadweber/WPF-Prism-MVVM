

using BFO.Core.BusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.Security
{
    public class owin_lastworkingpageFCC
    { 
	
		public owin_lastworkingpageFCC()
        {
		
        }
		
		public static Iowin_lastworkingpageFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
			Iowin_lastworkingpageFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;
            if (context != null)
            {
                facade = context.Items["Iowin_lastworkingpageFacadeObjects"] as Iowin_lastworkingpageFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_lastworkingpageFacadeObjects();
                    context.Items["Iowin_lastworkingpageFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_lastworkingpageFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}