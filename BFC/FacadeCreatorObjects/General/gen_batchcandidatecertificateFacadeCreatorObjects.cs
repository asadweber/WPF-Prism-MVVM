

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_batchcandidatecertificateFCC
    { 
	
		public gen_batchcandidatecertificateFCC()
        {
		
        }
		
		public static Igen_batchcandidatecertificateFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_batchcandidatecertificateFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_batchcandidatecertificateFacadeObjects"] as Igen_batchcandidatecertificateFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_batchcandidatecertificateFacadeObjects();
                    context.Items["Igen_batchcandidatecertificateFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_batchcandidatecertificateFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}