

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_rollbackinfoFCC
    { 
	
		public tran_rollbackinfoFCC()
        {
		
        }
		
		public static Itran_rollbackinfoFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_rollbackinfoFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Itran_rollbackinfoFacadeObjects"] as Itran_rollbackinfoFacadeObjects;
    
                if (facade == null)
                {
                    facade = new tran_rollbackinfoFacadeObjects();
                    context.Items["Itran_rollbackinfoFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_rollbackinfoFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}