

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_emergencycontactinfoFCC
    { 
	
		public reg_emergencycontactinfoFCC()
        {
		
        }
		
		public static Ireg_emergencycontactinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_emergencycontactinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_emergencycontactinfoFacadeObjects"] as Ireg_emergencycontactinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_emergencycontactinfoFacadeObjects();
                    context.Items["Ireg_emergencycontactinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_emergencycontactinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}