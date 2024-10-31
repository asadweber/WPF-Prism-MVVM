

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class stp_organizationFCC
    { 
	
		public stp_organizationFCC()
        {
		
        }
		
		public static Istp_organizationFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Istp_organizationFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Istp_organizationFacadeObjects"] as Istp_organizationFacadeObjects;
    
                if (facade == null)
                {
                    facade = new stp_organizationFacadeObjects();
                    context.Items["Istp_organizationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new stp_organizationFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}