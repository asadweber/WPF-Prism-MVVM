

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_notificationfiledetFCC
    { 
	
		public tran_notificationfiledetFCC()
        {
		
        }
		
		public static Itran_notificationfiledetFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_notificationfiledetFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_notificationfiledetFacadeObjects"] as Itran_notificationfiledetFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_notificationfiledetFacadeObjects();
                    context.Items["Itran_notificationfiledetFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_notificationfiledetFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}