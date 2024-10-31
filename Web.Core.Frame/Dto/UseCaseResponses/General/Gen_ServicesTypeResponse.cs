using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ServicesTypeResponse : UseCaseResponseMessage
    {
        public gen_servicestypeEntity _gen_ServicesType { get; }

        public IEnumerable<gen_servicestypeEntity> _gen_ServicesTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ServicesTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ServicesTypeResponse(IEnumerable<gen_servicestypeEntity> gen_ServicesTypeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServicesTypeList = gen_ServicesTypeList;
        }
        
        public Gen_ServicesTypeResponse(gen_servicestypeEntity gen_ServicesType, bool success = false, string message = null) : base(success, message)
        {
            _gen_ServicesType = gen_ServicesType;
        }

        public Gen_ServicesTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
