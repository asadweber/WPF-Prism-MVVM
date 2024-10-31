using BFO.Core.BusinessFacadeObjects.General;
using IBFO.Core.IBusinessFacadeObjects.General;
using Microsoft.AspNetCore.Http;

namespace BFC.Core.FacadeCreatorObjects.General
{
    public class tran_finalexamnotificationFCC
    {

        public tran_finalexamnotificationFCC()
        {

        }

        public static Itran_finalexamnotificationFacadeObjects GetFacadeCreate(IHttpContextAccessor httpContextAccessor)
        {
            Itran_finalexamnotificationFacadeObjects facade = null;
            var context = httpContextAccessor.HttpContext;

            if (context != null)
            {
                facade = context.Items["Itran_finalexamnotificationFacadeObjects"] as Itran_finalexamnotificationFacadeObjects;

                if (facade == null)
                {
                    facade = new tran_finalexamnotificationFacadeObjects();
                    context.Items["Itran_finalexamnotificationFacadeObjects"] = facade;
                }
            }
            else
            {
                facade = new tran_finalexamnotificationFacadeObjects();
                return facade;
            }
            return facade;
        }


    }
}