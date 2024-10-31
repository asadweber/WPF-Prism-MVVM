

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_relativesworkinginmodFCC
    { 
	
		public reg_relativesworkinginmodFCC()
        {
		
        }
		
		public static Ireg_relativesworkinginmodFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_relativesworkinginmodFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_relativesworkinginmodFacadeObjects"] as Ireg_relativesworkinginmodFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_relativesworkinginmodFacadeObjects();
                    context.Items["Ireg_relativesworkinginmodFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_relativesworkinginmodFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}