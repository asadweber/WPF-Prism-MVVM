

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_hobbiesFCC
    { 
	
		public reg_hobbiesFCC()
        {
		
        }
		
		public static Ireg_hobbiesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_hobbiesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_hobbiesFacadeObjects"] as Ireg_hobbiesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_hobbiesFacadeObjects();
                    context.Items["Ireg_hobbiesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_hobbiesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}