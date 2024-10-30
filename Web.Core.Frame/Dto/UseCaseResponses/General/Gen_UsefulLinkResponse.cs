using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_UsefulLinkResponse : UseCaseResponseMessage
    {
        public gen_usefullinkEntity _gen_UsefulLink { get; }

        public IEnumerable<gen_usefullinkEntity> _gen_UsefulLinkList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_UsefulLinkResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_UsefulLinkResponse(IEnumerable<gen_usefullinkEntity> gen_UsefulLinkList, bool success = false, string message = null) : base(success, message)
        {
            _gen_UsefulLinkList = gen_UsefulLinkList;
        }
        
        public Gen_UsefulLinkResponse(gen_usefullinkEntity gen_UsefulLink, bool success = false, string message = null) : base(success, message)
        {
            _gen_UsefulLink = gen_UsefulLink;
        }

        public Gen_UsefulLinkResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
