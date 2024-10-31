using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_EContactListResponse : UseCaseResponseMessage
    {
        public gen_econtactlistEntity _gen_EContactList { get; }

        public IEnumerable<gen_econtactlistEntity> _gen_EContactListList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_EContactListResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_EContactListResponse(IEnumerable<gen_econtactlistEntity> gen_EContactListList, bool success = false, string message = null) : base(success, message)
        {
            _gen_EContactListList = gen_EContactListList;
        }
        
        public Gen_EContactListResponse(gen_econtactlistEntity gen_EContactList, bool success = false, string message = null) : base(success, message)
        {
            _gen_EContactList = gen_EContactList;
        }

        public Gen_EContactListResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
