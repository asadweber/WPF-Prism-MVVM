using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_NonKuwaityStatusResponse : UseCaseResponseMessage
    {
        public gen_nonkuwaitystatusEntity _gen_NonKuwaityStatus { get; }

        public IEnumerable<gen_nonkuwaitystatusEntity> _gen_NonKuwaityStatusList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_NonKuwaityStatusResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_NonKuwaityStatusResponse(IEnumerable<gen_nonkuwaitystatusEntity> gen_NonKuwaityStatusList, bool success = false, string message = null) : base(success, message)
        {
            _gen_NonKuwaityStatusList = gen_NonKuwaityStatusList;
        }
        
        public Gen_NonKuwaityStatusResponse(gen_nonkuwaitystatusEntity gen_NonKuwaityStatus, bool success = false, string message = null) : base(success, message)
        {
            _gen_NonKuwaityStatus = gen_NonKuwaityStatus;
        }

        public Gen_NonKuwaityStatusResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
