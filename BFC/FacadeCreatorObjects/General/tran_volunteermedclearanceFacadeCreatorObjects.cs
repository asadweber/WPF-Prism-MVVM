

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_volunteermedclearanceFCC
    { 
	
		public tran_volunteermedclearanceFCC()
        {
		
        }
		
		public static Itran_volunteermedclearanceFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_volunteermedclearanceFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_volunteermedclearanceFacadeObjects"] as Itran_volunteermedclearanceFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_volunteermedclearanceFacadeObjects();
                    context.Items["Itran_volunteermedclearanceFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_volunteermedclearanceFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}