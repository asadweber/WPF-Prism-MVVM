using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ServiceStatusResponse : UseCaseResponseMessage
    {
        public gen_servicestatusEntity _gen_ServiceStatus { get; }

        public IEnumerable<gen_servicestatusEntity> _gen_ServiceStatusList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ServiceStatusResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ServiceStatusResponse(IEnumerable<gen_servicestatusEntity> gen_ServiceStatusList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServiceStatusList = gen_ServiceStatusList;
        }
        
        public Gen_ServiceStatusResponse(gen_servicestatusEntity gen_ServiceStatus, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServiceStatus = gen_ServiceStatus;
        }

        public Gen_ServiceStatusResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
