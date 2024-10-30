using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ServicesResponse : UseCaseResponseMessage
    {
        public gen_servicesEntity _gen_Services { get; }

        public IEnumerable<gen_servicesEntity> _gen_ServicesList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ServicesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ServicesResponse(IEnumerable<gen_servicesEntity> gen_ServicesList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServicesList = gen_ServicesList;
        }
        
        public Gen_ServicesResponse(gen_servicesEntity gen_Services, bool success = false, string message = null) : base(success, message)
        {
            _gen_Services = gen_Services;
        }

        public Gen_ServicesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
