

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_studentmenuskipdetailFCC
    { 
	
		public cnf_studentmenuskipdetailFCC()
        {
		
        }
		
		public static Icnf_studentmenuskipdetailFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_studentmenuskipdetailFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_studentmenuskipdetailFacadeObjects"] as Icnf_studentmenuskipdetailFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_studentmenuskipdetailFacadeObjects();
                    context.Items["Icnf_studentmenuskipdetailFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_studentmenuskipdetailFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}