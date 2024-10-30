using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Gen_DecisionTypeResponse : UseCaseResponseMessage
    {
        public kns_gen_decisiontypeEntity _kns_GenDecisionType { get; }

        public IEnumerable<kns_gen_decisiontypeEntity> _kns_GenDecisionTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Gen_DecisionTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Gen_DecisionTypeResponse(IEnumerable<kns_gen_decisiontypeEntity> kns_GenDecisionTypeList, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenDecisionTypeList = kns_GenDecisionTypeList;
        }
        
        public Kns_Gen_DecisionTypeResponse(kns_gen_decisiontypeEntity kns_GenDecisionType, bool success = false, string message = null) : base(success, message)
        {
            _kns_GenDecisionType = kns_GenDecisionType;
        }

        public Kns_Gen_DecisionTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
