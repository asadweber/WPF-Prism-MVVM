

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_trainingcentreFCC
    { 
	
		public gen_trainingcentreFCC()
        {
		
        }
		
		public static Igen_trainingcentreFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_trainingcentreFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_trainingcentreFacadeObjects"] as Igen_trainingcentreFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_trainingcentreFacadeObjects();
                    context.Items["Igen_trainingcentreFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_trainingcentreFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}