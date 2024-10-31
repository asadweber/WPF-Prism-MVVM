

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_syexamresultFCC
    { 
	
		public tran_syexamresultFCC()
        {
		
        }
		
		public static Itran_syexamresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_syexamresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_syexamresultFacadeObjects"] as Itran_syexamresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_syexamresultFacadeObjects();
                    context.Items["Itran_syexamresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_syexamresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}