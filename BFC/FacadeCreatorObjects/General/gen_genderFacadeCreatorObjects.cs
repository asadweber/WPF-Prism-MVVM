

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_genderFCC
    { 
	
		public gen_genderFCC()
        {
		
        }
		
		public static Igen_genderFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_genderFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_genderFacadeObjects"] as Igen_genderFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_genderFacadeObjects();
                    context.Items["Igen_genderFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_genderFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}