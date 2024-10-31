

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_notificationbatchdetFCC
    { 
	
		public tran_notificationbatchdetFCC()
        {
		
        }
		
		public static Itran_notificationbatchdetFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_notificationbatchdetFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_notificationbatchdetFacadeObjects"] as Itran_notificationbatchdetFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_notificationbatchdetFacadeObjects();
                    context.Items["Itran_notificationbatchdetFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_notificationbatchdetFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}