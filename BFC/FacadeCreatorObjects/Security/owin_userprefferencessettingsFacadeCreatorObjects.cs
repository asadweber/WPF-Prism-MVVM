

using BFO.Core.BusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.Security
{
    public class owin_userprefferencessettingsFCC
    { 
	
		public owin_userprefferencessettingsFCC()
        {
		
        }
		
		public static Iowin_userprefferencessettingsFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
			Iowin_userprefferencessettingsFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;
            if (context != null)
            {
                facade = context.Items["Iowin_userprefferencessettingsFacadeObjects"] as Iowin_userprefferencessettingsFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_userprefferencessettingsFacadeObjects();
                    context.Items["Iowin_userprefferencessettingsFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_userprefferencessettingsFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}