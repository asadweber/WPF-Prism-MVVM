using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_GenderResponse : UseCaseResponseMessage
    {
        public gen_genderEntity _gen_Gender { get; }

        public IEnumerable<gen_genderEntity> _gen_GenderList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_GenderResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_GenderResponse(IEnumerable<gen_genderEntity> gen_GenderList, bool success = false, string message = null) : base(success, message)
        {
            _gen_GenderList = gen_GenderList;
        }
        
        public Gen_GenderResponse(gen_genderEntity gen_Gender, bool success = false, string message = null) : base(success, message)
        {
            _gen_Gender = gen_Gender;
        }

        public Gen_GenderResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
