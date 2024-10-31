

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_punishmentFCC
    { 
	
		public reg_punishmentFCC()
        {
		
        }
		
		public static Ireg_punishmentFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_punishmentFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_punishmentFacadeObjects"] as Ireg_punishmentFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_punishmentFacadeObjects();
                    context.Items["Ireg_punishmentFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_punishmentFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}