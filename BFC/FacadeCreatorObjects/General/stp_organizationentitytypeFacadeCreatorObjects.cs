

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class stp_organizationentitytypeFCC
    { 
	
		public stp_organizationentitytypeFCC()
        {
		
        }
		
		public static Istp_organizationentitytypeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Istp_organizationentitytypeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Istp_organizationentitytypeFacadeObjects"] as Istp_organizationentitytypeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new stp_organizationentitytypeFacadeObjects();
                    context.Items["Istp_organizationentitytypeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new stp_organizationentitytypeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}