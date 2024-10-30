using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_ReasonTypeResponse : UseCaseResponseMessage
    {
        public kns_gen_reasontypeEntity _kns_GenReasonType { get; }

        public IEnumerable<kns_gen_reasontypeEntity> _kns_GenReasonTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_ReasonTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_ReasonTypeResponse(IEnumerable<kns_gen_reasontypeEntity> kns_GenReasonTypeList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenReasonTypeList = kns_GenReasonTypeList;
        }
        
        public Kns_Gen_ReasonTypeResponse(kns_gen_reasontypeEntity kns_GenReasonType, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenReasonType = kns_GenReasonType;
        }

        public Kns_Gen_ReasonTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
