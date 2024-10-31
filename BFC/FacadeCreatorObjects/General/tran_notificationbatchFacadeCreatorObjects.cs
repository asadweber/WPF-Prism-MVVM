

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_notificationbatchFCC
    { 
	
		public tran_notificationbatchFCC()
        {
		
        }
		
		public static Itran_notificationbatchFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_notificationbatchFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_notificationbatchFacadeObjects"] as Itran_notificationbatchFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_notificationbatchFacadeObjects();
                    context.Items["Itran_notificationbatchFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_notificationbatchFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}