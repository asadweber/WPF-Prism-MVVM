

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_finalexamresultFCC
    { 
	
		public tran_finalexamresultFCC()
        {
		
        }
		
		public static Itran_finalexamresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_finalexamresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_finalexamresultFacadeObjects"] as Itran_finalexamresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_finalexamresultFacadeObjects();
                    context.Items["Itran_finalexamresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_finalexamresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}