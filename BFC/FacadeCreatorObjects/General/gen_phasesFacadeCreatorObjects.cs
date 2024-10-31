

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_phasesFCC
    { 
	
		public gen_phasesFCC()
        {
		
        }
		
		public static Igen_phasesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_phasesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_phasesFacadeObjects"] as Igen_phasesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_phasesFacadeObjects();
                    context.Items["Igen_phasesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_phasesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}