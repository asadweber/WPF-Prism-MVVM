

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_datacheckedFCC
    { 
	
		public reg_datacheckedFCC()
        {
		
        }
		
		public static Ireg_datacheckedFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_datacheckedFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_datacheckedFacadeObjects"] as Ireg_datacheckedFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_datacheckedFacadeObjects();
                    context.Items["Ireg_datacheckedFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_datacheckedFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}