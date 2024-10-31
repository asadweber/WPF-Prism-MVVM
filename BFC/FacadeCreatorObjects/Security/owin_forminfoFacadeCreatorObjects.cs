

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class owin_forminfoFCC
    { 
	
		public owin_forminfoFCC()
        {
		
        }
		
		public static Iowin_forminfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Iowin_forminfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Iowin_forminfoFacadeObjects"] as Iowin_forminfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new owin_forminfoFacadeObjects();
                    context.Items["Iowin_forminfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new owin_forminfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}