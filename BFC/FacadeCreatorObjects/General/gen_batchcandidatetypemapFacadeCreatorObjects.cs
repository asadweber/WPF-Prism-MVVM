

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_batchcandidatetypemapFCC
    { 
	
		public gen_batchcandidatetypemapFCC()
        {
		
        }
		
		public static Igen_batchcandidatetypemapFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_batchcandidatetypemapFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_batchcandidatetypemapFacadeObjects"] as Igen_batchcandidatetypemapFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_batchcandidatetypemapFacadeObjects();
                    context.Items["Igen_batchcandidatetypemapFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_batchcandidatetypemapFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}