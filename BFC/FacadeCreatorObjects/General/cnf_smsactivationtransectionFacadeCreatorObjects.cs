

using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class cnf_smsactivationtransectionFCC
    { 
	
		public cnf_smsactivationtransectionFCC()
        {
		
        }
		
		public static Icnf_smsactivationtransectionFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Icnf_smsactivationtransectionFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;			
            
            if (context != null)
            {
                facade = context.Items["Icnf_smsactivationtransectionFacadeObjects"] as Icnf_smsactivationtransectionFacadeObjects;
    
                if (facade == null)
                {
                    facade = new cnf_smsactivationtransectionFacadeObjects();
                    context.Items["Icnf_smsactivationtransectionFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new cnf_smsactivationtransectionFacadeObjects();
                return facade;
            }
            return facade;
        }
		
		
	}
}