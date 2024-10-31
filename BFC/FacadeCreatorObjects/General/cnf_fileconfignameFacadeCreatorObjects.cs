

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_fileconfignameFCC
    { 
	
		public cnf_fileconfignameFCC()
        {
		
        }
		
		public static Icnf_fileconfignameFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_fileconfignameFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_fileconfignameFacadeObjects"] as Icnf_fileconfignameFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_fileconfignameFacadeObjects();
                    context.Items["Icnf_fileconfignameFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_fileconfignameFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}