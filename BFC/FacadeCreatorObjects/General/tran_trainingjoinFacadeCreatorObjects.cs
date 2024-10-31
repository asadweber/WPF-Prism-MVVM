

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_trainingjoinFCC
    { 
	
		public tran_trainingjoinFCC()
        {
		
        }
		
		public static Itran_trainingjoinFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_trainingjoinFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_trainingjoinFacadeObjects"] as Itran_trainingjoinFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_trainingjoinFacadeObjects();
                    context.Items["Itran_trainingjoinFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_trainingjoinFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}