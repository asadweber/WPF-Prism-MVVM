

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_applicantresultexpireFCC
    { 
	
		public tran_applicantresultexpireFCC()
        {
		
        }
		
		public static Itran_applicantresultexpireFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_applicantresultexpireFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_applicantresultexpireFacadeObjects"] as Itran_applicantresultexpireFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_applicantresultexpireFacadeObjects();
                    context.Items["Itran_applicantresultexpireFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_applicantresultexpireFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}