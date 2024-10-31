

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_auditresultFCC
    { 
	
		public tran_auditresultFCC()
        {
		
        }
		
		public static Itran_auditresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_auditresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_auditresultFacadeObjects"] as Itran_auditresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_auditresultFacadeObjects();
                    context.Items["Itran_auditresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_auditresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}