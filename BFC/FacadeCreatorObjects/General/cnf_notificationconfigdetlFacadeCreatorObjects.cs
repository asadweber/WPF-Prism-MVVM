

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_notificationconfigdetlFCC
    { 
	
		public cnf_notificationconfigdetlFCC()
        {
		
        }
		
		public static Icnf_notificationconfigdetlFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_notificationconfigdetlFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_notificationconfigdetlFacadeObjects"] as Icnf_notificationconfigdetlFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_notificationconfigdetlFacadeObjects();
                    context.Items["Icnf_notificationconfigdetlFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_notificationconfigdetlFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}