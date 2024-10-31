

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_famillyFCC
    { 
	
		public reg_famillyFCC()
        {
		
        }
		
		public static Ireg_famillyFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_famillyFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_famillyFacadeObjects"] as Ireg_famillyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_famillyFacadeObjects();
                    context.Items["Ireg_famillyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_famillyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}