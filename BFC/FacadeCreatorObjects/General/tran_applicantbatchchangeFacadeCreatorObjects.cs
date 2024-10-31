

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_applicantbatchchangeFCC
    { 
	
		public tran_applicantbatchchangeFCC()
        {
		
        }
		
		public static Itran_applicantbatchchangeFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_applicantbatchchangeFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_applicantbatchchangeFacadeObjects"] as Itran_applicantbatchchangeFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_applicantbatchchangeFacadeObjects();
                    context.Items["Itran_applicantbatchchangeFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_applicantbatchchangeFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}