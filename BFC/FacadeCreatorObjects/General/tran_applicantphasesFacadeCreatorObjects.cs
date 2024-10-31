

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_applicantphasesFCC
    { 
	
		public tran_applicantphasesFCC()
        {
		
        }
		
		public static Itran_applicantphasesFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_applicantphasesFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_applicantphasesFacadeObjects"] as Itran_applicantphasesFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_applicantphasesFacadeObjects();
                    context.Items["Itran_applicantphasesFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_applicantphasesFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}