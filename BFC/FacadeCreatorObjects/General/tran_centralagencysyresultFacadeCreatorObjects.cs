

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_centralagencysyresultFCC
    { 
	
		public tran_centralagencysyresultFCC()
        {
		
        }
		
		public static Itran_centralagencysyresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_centralagencysyresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_centralagencysyresultFacadeObjects"] as Itran_centralagencysyresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_centralagencysyresultFacadeObjects();
                    context.Items["Itran_centralagencysyresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_centralagencysyresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}