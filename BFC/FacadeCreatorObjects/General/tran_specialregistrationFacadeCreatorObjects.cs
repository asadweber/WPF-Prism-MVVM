

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_specialregistrationFCC
    { 
	
		public tran_specialregistrationFCC()
        {
		
        }
		
		public static Itran_specialregistrationFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_specialregistrationFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_specialregistrationFacadeObjects"] as Itran_specialregistrationFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_specialregistrationFacadeObjects();
                    context.Items["Itran_specialregistrationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_specialregistrationFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}