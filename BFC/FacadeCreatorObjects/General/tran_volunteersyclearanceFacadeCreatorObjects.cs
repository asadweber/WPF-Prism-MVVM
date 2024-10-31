

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_volunteersyclearanceFCC
    { 
	
		public tran_volunteersyclearanceFCC()
        {
		
        }
		
		public static Itran_volunteersyclearanceFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_volunteersyclearanceFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_volunteersyclearanceFacadeObjects"] as Itran_volunteersyclearanceFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_volunteersyclearanceFacadeObjects();
                    context.Items["Itran_volunteersyclearanceFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_volunteersyclearanceFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}