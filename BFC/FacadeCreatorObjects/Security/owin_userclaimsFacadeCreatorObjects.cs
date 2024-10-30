


using BFO.Core.BusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.Security
{
    public class owin_userclaimsFCC
    { 
	
		public owin_userclaimsFCC()
        {
		
        }
		
		public static Iowin_userclaimsFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
			Iowin_userclaimsFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;
            if (context != null)
            {
                facade = context.Items["Iowin_userclaimsFacadeObjects"] as Iowin_userclaimsFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_userclaimsFacadeObjects();
                    context.Items["Iowin_userclaimsFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_userclaimsFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}