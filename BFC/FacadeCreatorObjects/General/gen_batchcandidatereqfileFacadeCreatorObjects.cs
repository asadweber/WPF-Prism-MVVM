

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_batchcandidatereqfileFCC
    { 
	
		public gen_batchcandidatereqfileFCC()
        {
		
        }
		
		public static Igen_batchcandidatereqfileFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_batchcandidatereqfileFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_batchcandidatereqfileFacadeObjects"] as Igen_batchcandidatereqfileFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_batchcandidatereqfileFacadeObjects();
                    context.Items["Igen_batchcandidatereqfileFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_batchcandidatereqfileFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}