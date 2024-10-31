

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_syexamnotificationFCC
    { 
	
		public tran_syexamnotificationFCC()
        {
		
        }
		
		public static Itran_syexamnotificationFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_syexamnotificationFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_syexamnotificationFacadeObjects"] as Itran_syexamnotificationFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_syexamnotificationFacadeObjects();
                    context.Items["Itran_syexamnotificationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_syexamnotificationFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}