using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_BatchDetailResponse : UseCaseResponseMessage
    {
        public kns_batchdetailEntity _kns_BatchDetail { get; }

        public IEnumerable<kns_batchdetailEntity> _kns_BatchDetailList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_BatchDetailResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_BatchDetailResponse(IEnumerable<kns_batchdetailEntity> kns_BatchDetailList, bool success = false, string message = null) : base(success, message)
        {
            _kns_BatchDetailList = kns_BatchDetailList;
        }
        
        public Kns_BatchDetailResponse(kns_batchdetailEntity kns_BatchDetail, bool success = false, string message = null) : base(success, message)
        {
            _kns_BatchDetail = kns_BatchDetail;
        }

        public Kns_BatchDetailResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
