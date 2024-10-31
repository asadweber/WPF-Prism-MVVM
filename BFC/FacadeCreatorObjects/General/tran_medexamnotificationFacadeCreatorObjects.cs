

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_medexamnotificationFCC
    { 
	
		public tran_medexamnotificationFCC()
        {
		
        }
		
		public static Itran_medexamnotificationFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_medexamnotificationFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_medexamnotificationFacadeObjects"] as Itran_medexamnotificationFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_medexamnotificationFacadeObjects();
                    context.Items["Itran_medexamnotificationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_medexamnotificationFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}