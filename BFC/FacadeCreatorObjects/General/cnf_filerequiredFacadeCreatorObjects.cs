

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_filerequiredFCC
    { 
	
		public cnf_filerequiredFCC()
        {
		
        }
		
		public static Icnf_filerequiredFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_filerequiredFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_filerequiredFacadeObjects"] as Icnf_filerequiredFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_filerequiredFacadeObjects();
                    context.Items["Icnf_filerequiredFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_filerequiredFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}