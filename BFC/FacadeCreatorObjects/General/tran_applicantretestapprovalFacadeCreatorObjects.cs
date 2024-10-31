

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_applicantretestapprovalFCC
    { 
	
		public tran_applicantretestapprovalFCC()
        {
		
        }
		
		public static Itran_applicantretestapprovalFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_applicantretestapprovalFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_applicantretestapprovalFacadeObjects"] as Itran_applicantretestapprovalFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_applicantretestapprovalFacadeObjects();
                    context.Items["Itran_applicantretestapprovalFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_applicantretestapprovalFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}