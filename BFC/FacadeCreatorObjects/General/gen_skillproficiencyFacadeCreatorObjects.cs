

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class gen_skillproficiencyFCC
    { 
	
		public gen_skillproficiencyFCC()
        {
		
        }
		
		public static Igen_skillproficiencyFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Igen_skillproficiencyFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Igen_skillproficiencyFacadeObjects"] as Igen_skillproficiencyFacadeObjects;
    
                if (facade == null)
                {
                    facade = new gen_skillproficiencyFacadeObjects();
                    context.Items["Igen_skillproficiencyFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new gen_skillproficiencyFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}