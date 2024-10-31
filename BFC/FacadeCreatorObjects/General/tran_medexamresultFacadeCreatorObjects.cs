

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_medexamresultFCC
    { 
	
		public tran_medexamresultFCC()
        {
		
        }
		
		public static Itran_medexamresultFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_medexamresultFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_medexamresultFacadeObjects"] as Itran_medexamresultFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_medexamresultFacadeObjects();
                    context.Items["Itran_medexamresultFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_medexamresultFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}