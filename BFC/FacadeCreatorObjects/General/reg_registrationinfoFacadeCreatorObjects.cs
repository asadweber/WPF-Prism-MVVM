

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_registrationinfoFCC
    { 
	
		public reg_registrationinfoFCC()
        {
		
        }
		
		public static Ireg_registrationinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_registrationinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_registrationinfoFacadeObjects"] as Ireg_registrationinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_registrationinfoFacadeObjects();
                    context.Items["Ireg_registrationinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_registrationinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}