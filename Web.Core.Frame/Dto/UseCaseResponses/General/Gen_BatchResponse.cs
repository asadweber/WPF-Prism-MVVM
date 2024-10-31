using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BatchResponse : UseCaseResponseMessage
    {
        public gen_batchEntity _gen_Batch { get; }

        public IEnumerable<gen_batchEntity> _gen_BatchList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BatchResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BatchResponse(IEnumerable<gen_batchEntity> gen_BatchList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchList = gen_BatchList;
        }
        
        public Gen_BatchResponse(gen_batchEntity gen_Batch, bool success = false, string message = null) : base(success, message)
        {
            _gen_Batch = gen_Batch;
        }

        public Gen_BatchResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
