using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_FAQCategoryResponse : UseCaseResponseMessage
    {
        public gen_faqcategoryEntity _gen_FAQCategory { get; }

        public IEnumerable<gen_faqcategoryEntity> _gen_FAQCategoryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_FAQCategoryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_FAQCategoryResponse(IEnumerable<gen_faqcategoryEntity> gen_FAQCategoryList, bool success = false, string message = null) : base(success, message)
        {
            _gen_FAQCategoryList = gen_FAQCategoryList;
        }
        
        public Gen_FAQCategoryResponse(gen_faqcategoryEntity gen_FAQCategory, bool success = false, string message = null) : base(success, message)
        {
            _gen_FAQCategory = gen_FAQCategory;
        }

        public Gen_FAQCategoryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
