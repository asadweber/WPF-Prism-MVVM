

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_notificationtempletFCC
    { 
	
		public cnf_notificationtempletFCC()
        {
		
        }
		
		public static Icnf_notificationtempletFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_notificationtempletFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_notificationtempletFacadeObjects"] as Icnf_notificationtempletFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_notificationtempletFacadeObjects();
                    context.Items["Icnf_notificationtempletFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_notificationtempletFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}