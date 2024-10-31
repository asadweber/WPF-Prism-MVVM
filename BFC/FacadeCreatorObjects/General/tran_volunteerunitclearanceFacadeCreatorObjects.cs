

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_volunteerunitclearanceFCC
    { 
	
		public tran_volunteerunitclearanceFCC()
        {
		
        }
		
		public static Itran_volunteerunitclearanceFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_volunteerunitclearanceFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_volunteerunitclearanceFacadeObjects"] as Itran_volunteerunitclearanceFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_volunteerunitclearanceFacadeObjects();
                    context.Items["Itran_volunteerunitclearanceFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_volunteerunitclearanceFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}