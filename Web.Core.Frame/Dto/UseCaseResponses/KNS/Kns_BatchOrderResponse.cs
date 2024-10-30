using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_BatchOrderResponse : UseCaseResponseMessage
    {
        public kns_batchorderEntity _kns_BatchOrder { get; }

        public IEnumerable<kns_batchorderEntity> _kns_BatchOrderList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_BatchOrderResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_BatchOrderResponse(IEnumerable<kns_batchorderEntity> kns_BatchOrderList, bool success = false, string message = null) : base(success, message)
        {
            _kns_BatchOrderList = kns_BatchOrderList;
        }
        
        public Kns_BatchOrderResponse(kns_batchorderEntity kns_BatchOrder, bool success = false, string message = null) : base(success, message)
        {
            _kns_BatchOrder = kns_BatchOrder;
        }

        public Kns_BatchOrderResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
