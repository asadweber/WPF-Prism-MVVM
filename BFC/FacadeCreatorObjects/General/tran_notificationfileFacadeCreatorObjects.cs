

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_notificationfileFCC
    { 
	
		public tran_notificationfileFCC()
        {
		
        }
		
		public static Itran_notificationfileFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_notificationfileFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_notificationfileFacadeObjects"] as Itran_notificationfileFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_notificationfileFacadeObjects();
                    context.Items["Itran_notificationfileFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_notificationfileFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}