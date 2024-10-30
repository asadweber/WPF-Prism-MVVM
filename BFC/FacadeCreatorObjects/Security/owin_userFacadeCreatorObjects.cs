

using BFO.Core.BusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.Security
{
    public class owin_userFCC
    { 
	
		public owin_userFCC()
        {
		
        }
		
		public static Iowin_userFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
			Iowin_userFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;
            if (context != null)
            {
                facade = context.Items["Iowin_userFacadeObjects"] as Iowin_userFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_userFacadeObjects();
                    context.Items["Iowin_userFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_userFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}