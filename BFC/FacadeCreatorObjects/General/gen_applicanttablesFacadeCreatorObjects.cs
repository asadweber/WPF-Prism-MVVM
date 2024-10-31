

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_applicanttablesFCC
    { 
	
		public gen_applicanttablesFCC()
        {
		
        }
		
		public static Igen_applicanttablesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_applicanttablesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_applicanttablesFacadeObjects"] as Igen_applicanttablesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_applicanttablesFacadeObjects();
                    context.Items["Igen_applicanttablesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_applicanttablesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}