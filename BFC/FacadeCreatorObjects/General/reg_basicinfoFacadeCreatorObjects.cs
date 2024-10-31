

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_basicinfoFCC
    { 
	
		public reg_basicinfoFCC()
        {
		
        }
		
		public static Ireg_basicinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_basicinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_basicinfoFacadeObjects"] as Ireg_basicinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_basicinfoFacadeObjects();
                    context.Items["Ireg_basicinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_basicinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}