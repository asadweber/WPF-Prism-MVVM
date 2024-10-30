


using BFO.Core.BusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.Security
{
    public class owin_roleFCC
    { 
	
		public owin_roleFCC()
        {
		
        }
		
		public static Iowin_roleFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
			Iowin_roleFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;
            if (context != null)
            {
                facade = context.Items["Iowin_roleFacadeObjects"] as Iowin_roleFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_roleFacadeObjects();
                    context.Items["Iowin_roleFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_roleFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}