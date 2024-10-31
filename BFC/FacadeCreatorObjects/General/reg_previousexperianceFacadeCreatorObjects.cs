

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_previousexperianceFCC
    { 
	
		public reg_previousexperianceFCC()
        {
		
        }
		
		public static Ireg_previousexperianceFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_previousexperianceFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_previousexperianceFacadeObjects"] as Ireg_previousexperianceFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_previousexperianceFacadeObjects();
                    context.Items["Ireg_previousexperianceFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_previousexperianceFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}