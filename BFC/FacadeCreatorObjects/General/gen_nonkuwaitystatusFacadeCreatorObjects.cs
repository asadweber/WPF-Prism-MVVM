

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_nonkuwaitystatusFCC
    { 
	
		public gen_nonkuwaitystatusFCC()
        {
		
        }
		
		public static Igen_nonkuwaitystatusFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_nonkuwaitystatusFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_nonkuwaitystatusFacadeObjects"] as Igen_nonkuwaitystatusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_nonkuwaitystatusFacadeObjects();
                    context.Items["Igen_nonkuwaitystatusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_nonkuwaitystatusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}