

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class reg_studentfilestorageFCC
    { 
	
		public reg_studentfilestorageFCC()
        {
		
        }
		
		public static Ireg_studentfilestorageFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Ireg_studentfilestorageFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Ireg_studentfilestorageFacadeObjects"] as Ireg_studentfilestorageFacadeObjects;
    
                if (facade == null)
                {
                    facade = new reg_studentfilestorageFacadeObjects();
                    context.Items["Ireg_studentfilestorageFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new reg_studentfilestorageFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}