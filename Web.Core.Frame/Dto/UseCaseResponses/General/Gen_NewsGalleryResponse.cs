using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_NewsGalleryResponse : UseCaseResponseMessage
    {
        public gen_newsgalleryEntity _gen_NewsGallery { get; }

        public IEnumerable<gen_newsgalleryEntity> _gen_NewsGalleryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_NewsGalleryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_NewsGalleryResponse(IEnumerable<gen_newsgalleryEntity> gen_NewsGalleryList, bool success = false, string message = null) : base(success, message)
        {
            _gen_NewsGalleryList = gen_NewsGalleryList;
        }
        
        public Gen_NewsGalleryResponse(gen_newsgalleryEntity gen_NewsGallery, bool success = false, string message = null) : base(success, message)
        {
            _gen_NewsGallery = gen_NewsGallery;
        }

        public Gen_NewsGalleryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
