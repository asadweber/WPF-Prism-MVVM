using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_NewsCategoryResponse : UseCaseResponseMessage
    {
        public gen_newscategoryEntity _gen_NewsCategory { get; }

        public IEnumerable<gen_newscategoryEntity> _gen_NewsCategoryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_NewsCategoryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_NewsCategoryResponse(IEnumerable<gen_newscategoryEntity> gen_NewsCategoryList, bool success = false, string message = null) : base(success, message)
        {
            _gen_NewsCategoryList = gen_NewsCategoryList;
        }
        
        public Gen_NewsCategoryResponse(gen_newscategoryEntity gen_NewsCategory, bool success = false, string message = null) : base(success, message)
        {
            _gen_NewsCategory = gen_NewsCategory;
        }

        public Gen_NewsCategoryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
