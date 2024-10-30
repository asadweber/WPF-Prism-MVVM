

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_loginFCC
    { 
	
		public tran_loginFCC()
        {
		
        }
		
		public static Itran_loginFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_loginFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_loginFacadeObjects"] as Itran_loginFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_loginFacadeObjects();
                    context.Items["Itran_loginFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_loginFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}