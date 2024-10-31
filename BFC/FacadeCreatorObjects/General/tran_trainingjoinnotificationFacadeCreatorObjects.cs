using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_trainingjoinnotificationFCC
    {

        public tran_trainingjoinnotificationFCC()
        {

        }

        public static Itran_trainingjoinnotificationFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_trainingjoinnotificationFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;

            if (context != null)
            {
                facade = context.Items["Itran_trainingjoinnotificationFacadeObjects"] as Itran_trainingjoinnotificationFacadeObjects;

                if (facade == null)
                {
                    facade = new tran_trainingjoinnotificationFacadeObjects();
                    context.Items["Itran_trainingjoinnotificationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_trainingjoinnotificationFacadeObjects();
                return facade;
            }
            return facade;
        }


    }
}