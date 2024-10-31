using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_GeneralLookResponse : UseCaseResponseMessage
    {
        public gen_generallookEntity _gen_GeneralLook { get; }

        public IEnumerable<gen_generallookEntity> _gen_GeneralLookList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_GeneralLookResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_GeneralLookResponse(IEnumerable<gen_generallookEntity> gen_GeneralLookList, bool success = false, string message = null) : base(success, message)
        {
            _gen_GeneralLookList = gen_GeneralLookList;
        }
        
        public Gen_GeneralLookResponse(gen_generallookEntity gen_GeneralLook, bool success = false, string message = null) : base(success, message)
        {
            _gen_GeneralLook = gen_GeneralLook;
        }

        public Gen_GeneralLookResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
