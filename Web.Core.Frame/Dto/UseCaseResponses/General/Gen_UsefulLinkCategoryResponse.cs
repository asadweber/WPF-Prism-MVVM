using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_UsefulLinkCategoryResponse : UseCaseResponseMessage
    {
        public gen_usefullinkcategoryEntity _gen_UsefulLinkCategory { get; }

        public IEnumerable<gen_usefullinkcategoryEntity> _gen_UsefulLinkCategoryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_UsefulLinkCategoryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_UsefulLinkCategoryResponse(IEnumerable<gen_usefullinkcategoryEntity> gen_UsefulLinkCategoryList, bool success = false, string message = null) : base(success, message)
        {
            _gen_UsefulLinkCategoryList = gen_UsefulLinkCategoryList;
        }
        
        public Gen_UsefulLinkCategoryResponse(gen_usefullinkcategoryEntity gen_UsefulLinkCategory, bool success = false, string message = null) : base(success, message)
        {
            _gen_UsefulLinkCategory = gen_UsefulLinkCategory;
        }

        public Gen_UsefulLinkCategoryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
