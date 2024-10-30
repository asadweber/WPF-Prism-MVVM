using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_BatchResponse : UseCaseResponseMessage
    {
        public kns_batchEntity _kns_Batch { get; }

        public IEnumerable<kns_batchEntity> _kns_BatchList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_BatchResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_BatchResponse(IEnumerable<kns_batchEntity> kns_BatchList, bool success = false, string message = null) : base(success, message)
        {
            _kns_BatchList = kns_BatchList;
        }
        
        public Kns_BatchResponse(kns_batchEntity kns_Batch, bool success = false, string message = null) : base(success, message)
        {
            _kns_Batch = kns_Batch;
        }

        public Kns_BatchResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
