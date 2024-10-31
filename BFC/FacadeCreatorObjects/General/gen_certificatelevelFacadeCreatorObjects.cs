

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_certificatelevelFCC
    { 
	
		public gen_certificatelevelFCC()
        {
		
        }
		
		public static Igen_certificatelevelFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_certificatelevelFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_certificatelevelFacadeObjects"] as Igen_certificatelevelFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_certificatelevelFacadeObjects();
                    context.Items["Igen_certificatelevelFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_certificatelevelFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}