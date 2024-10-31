

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_maritalstatusFCC
    { 
	
		public gen_maritalstatusFCC()
        {
		
        }
		
		public static Igen_maritalstatusFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_maritalstatusFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_maritalstatusFacadeObjects"] as Igen_maritalstatusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_maritalstatusFacadeObjects();
                    context.Items["Igen_maritalstatusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_maritalstatusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}