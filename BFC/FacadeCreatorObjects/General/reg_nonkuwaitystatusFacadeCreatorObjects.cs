

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_nonkuwaitystatusFCC
    { 
	
		public reg_nonkuwaitystatusFCC()
        {
		
        }
		
		public static Ireg_nonkuwaitystatusFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_nonkuwaitystatusFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_nonkuwaitystatusFacadeObjects"] as Ireg_nonkuwaitystatusFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_nonkuwaitystatusFacadeObjects();
                    context.Items["Ireg_nonkuwaitystatusFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_nonkuwaitystatusFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}