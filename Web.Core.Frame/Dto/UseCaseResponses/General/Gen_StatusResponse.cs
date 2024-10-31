using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_StatusResponse : UseCaseResponseMessage
    {
        public gen_statusEntity _gen_Status { get; }

        public IEnumerable<gen_statusEntity> _gen_StatusList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_StatusResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_StatusResponse(IEnumerable<gen_statusEntity> gen_StatusList, bool success = false, string message = null) : base(success, message)
        {
            _gen_StatusList = gen_StatusList;
        }
        
        public Gen_StatusResponse(gen_statusEntity gen_Status, bool success = false, string message = null) : base(success, message)
        {
            _gen_Status = gen_Status;
        }

        public Gen_StatusResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
