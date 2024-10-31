

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_unitclearanceresultFCC
    { 
	
		public tran_unitclearanceresultFCC()
        {
		
        }
		
		public static Itran_unitclearanceresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_unitclearanceresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_unitclearanceresultFacadeObjects"] as Itran_unitclearanceresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_unitclearanceresultFacadeObjects();
                    context.Items["Itran_unitclearanceresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_unitclearanceresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}