

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_studentmenuskipFCC
    { 
	
		public cnf_studentmenuskipFCC()
        {
		
        }
		
		public static Icnf_studentmenuskipFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_studentmenuskipFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_studentmenuskipFacadeObjects"] as Icnf_studentmenuskipFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_studentmenuskipFacadeObjects();
                    context.Items["Icnf_studentmenuskipFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_studentmenuskipFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}