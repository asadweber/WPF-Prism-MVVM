using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class KNS_HangfireJobDetailResponse : UseCaseResponseMessage
    {
        public kns_hangfirejobdetailEntity _kns_HangfireJobDetail { get; }

        public IEnumerable<kns_hangfirejobdetailEntity> _kns_HangfireJobDetailList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public KNS_HangfireJobDetailResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public KNS_HangfireJobDetailResponse(IEnumerable<kns_hangfirejobdetailEntity> kns_HangfireJobDetailList, bool success = false, string message = null) : base(success, message)
        {
            _kns_HangfireJobDetailList = kns_HangfireJobDetailList;
        }
        
        public KNS_HangfireJobDetailResponse(kns_hangfirejobdetailEntity kns_HangfireJobDetail, bool success = false, string message = null) : base(success, message)
        {
            _kns_HangfireJobDetail = kns_HangfireJobDetail;
        }

        public KNS_HangfireJobDetailResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
