using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ImageGallaryCategoryResponse : UseCaseResponseMessage
    {
        public gen_imagegallarycategoryEntity _gen_ImageGallaryCategory { get; }

        public IEnumerable<gen_imagegallarycategoryEntity> _gen_ImageGallaryCategoryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ImageGallaryCategoryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ImageGallaryCategoryResponse(IEnumerable<gen_imagegallarycategoryEntity> gen_ImageGallaryCategoryList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ImageGallaryCategoryList = gen_ImageGallaryCategoryList;
        }
        
        public Gen_ImageGallaryCategoryResponse(gen_imagegallarycategoryEntity gen_ImageGallaryCategory, bool success = false, string message = null) : base(success, message)
        {
            _gen_ImageGallaryCategory = gen_ImageGallaryCategory;
        }

        public Gen_ImageGallaryCategoryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
