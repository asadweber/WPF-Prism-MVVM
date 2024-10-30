using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_ReasonResponse : UseCaseResponseMessage
    {
        public kns_gen_reasonEntity _kns_GenReason { get; }

        public IEnumerable<kns_gen_reasonEntity> _kns_GenReasonList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_ReasonResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_ReasonResponse(IEnumerable<kns_gen_reasonEntity> kns_GenReasonList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenReasonList = kns_GenReasonList;
        }
        
        public Kns_Gen_ReasonResponse(kns_gen_reasonEntity kns_GenReason, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenReason = kns_GenReason;
        }

        public Kns_Gen_ReasonResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
