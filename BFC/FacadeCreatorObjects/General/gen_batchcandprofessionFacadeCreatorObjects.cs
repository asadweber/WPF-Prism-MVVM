

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_batchcandprofessionFCC
    { 
	
		public gen_batchcandprofessionFCC()
        {
		
        }
		
		public static Igen_batchcandprofessionFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_batchcandprofessionFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_batchcandprofessionFacadeObjects"] as Igen_batchcandprofessionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_batchcandprofessionFacadeObjects();
                    context.Items["Igen_batchcandprofessionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_batchcandprofessionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}