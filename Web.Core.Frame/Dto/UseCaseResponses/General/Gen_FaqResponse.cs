using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_FaqResponse : UseCaseResponseMessage
    {
        public gen_faqEntity _gen_Faq { get; }

        public IEnumerable<gen_faqEntity> _gen_FaqList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_FaqResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_FaqResponse(IEnumerable<gen_faqEntity> gen_FaqList, bool success = false, string message = null) : base(success, message)
        {
            _gen_FaqList = gen_FaqList;
        }
        
        public Gen_FaqResponse(gen_faqEntity gen_Faq, bool success = false, string message = null) : base(success, message)
        {
            _gen_Faq = gen_Faq;
        }

        public Gen_FaqResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
