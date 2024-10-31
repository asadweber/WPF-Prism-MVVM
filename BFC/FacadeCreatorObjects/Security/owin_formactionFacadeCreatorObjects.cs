

using BFO.Core.BusinessFacadeObjects.Security;
using IBFO.Core.IBusinessFacadeObjects.Security;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.Security
{ 
    public class owin_formactionFCC
    { 
	
		public owin_formactionFCC()
        {
		
        }
		
		public static Iowin_formactionFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
			Iowin_formactionFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;
            if (context != null)
            {
                facade = context.Items["Iowin_formactionFacadeObjects"] as Iowin_formactionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_formactionFacadeObjects();
                    context.Items["Iowin_formactionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_formactionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}