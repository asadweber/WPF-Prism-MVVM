using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ServiceInfoResponse : UseCaseResponseMessage
    {
        public gen_serviceinfoEntity _gen_ServiceInfo { get; }

        public IEnumerable<gen_serviceinfoEntity> _gen_ServiceInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ServiceInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ServiceInfoResponse(IEnumerable<gen_serviceinfoEntity> gen_ServiceInfoList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServiceInfoList = gen_ServiceInfoList;
        }
        
        public Gen_ServiceInfoResponse(gen_serviceinfoEntity gen_ServiceInfo, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServiceInfo = gen_ServiceInfo;
        }

        public Gen_ServiceInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
