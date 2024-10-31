

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_psychoexamresultFCC
    { 
	
		public tran_psychoexamresultFCC()
        {
		
        }
		
		public static Itran_psychoexamresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_psychoexamresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_psychoexamresultFacadeObjects"] as Itran_psychoexamresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_psychoexamresultFacadeObjects();
                    context.Items["Itran_psychoexamresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_psychoexamresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}