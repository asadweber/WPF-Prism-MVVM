

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_languageFCC
    { 
	
		public reg_languageFCC()
        {
		
        }
		
		public static Ireg_languageFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_languageFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_languageFacadeObjects"] as Ireg_languageFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_languageFacadeObjects();
                    context.Items["Ireg_languageFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_languageFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}