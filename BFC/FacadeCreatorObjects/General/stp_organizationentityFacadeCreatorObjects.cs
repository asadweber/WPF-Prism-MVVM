

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class stp_organizationentityFCC
    { 
	
		public stp_organizationentityFCC()
        {
		
        }
		
		public static Istp_organizationentityFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Istp_organizationentityFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Istp_organizationentityFacadeObjects"] as Istp_organizationentityFacadeObjects;
    
                if (facade == null)
                {
                    facade = new stp_organizationentityFacadeObjects();
                    context.Items["Istp_organizationentityFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new stp_organizationentityFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}