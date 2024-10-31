

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_smsactivationcodeFCC
    { 
	
		public cnf_smsactivationcodeFCC()
        {
		
        }
		
		public static Icnf_smsactivationcodeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_smsactivationcodeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_smsactivationcodeFacadeObjects"] as Icnf_smsactivationcodeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_smsactivationcodeFacadeObjects();
                    context.Items["Icnf_smsactivationcodeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_smsactivationcodeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}