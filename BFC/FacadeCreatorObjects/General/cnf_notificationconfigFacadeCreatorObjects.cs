

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_notificationconfigFCC
    { 
	
		public cnf_notificationconfigFCC()
        {
		
        }
		
		public static Icnf_notificationconfigFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_notificationconfigFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_notificationconfigFacadeObjects"] as Icnf_notificationconfigFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_notificationconfigFacadeObjects();
                    context.Items["Icnf_notificationconfigFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_notificationconfigFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}