

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_exportprofileFCC
    { 
	
		public tran_exportprofileFCC()
        {
		
        }
		
		public static Itran_exportprofileFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_exportprofileFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_exportprofileFacadeObjects"] as Itran_exportprofileFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_exportprofileFacadeObjects();
                    context.Items["Itran_exportprofileFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_exportprofileFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}