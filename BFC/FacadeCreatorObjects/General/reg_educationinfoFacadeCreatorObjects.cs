

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_educationinfoFCC
    { 
	
		public reg_educationinfoFCC()
        {
		
        }
		
		public static Ireg_educationinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_educationinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_educationinfoFacadeObjects"] as Ireg_educationinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_educationinfoFacadeObjects();
                    context.Items["Ireg_educationinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_educationinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}