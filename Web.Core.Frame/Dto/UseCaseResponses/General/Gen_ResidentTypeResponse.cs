using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ResidentTypeResponse : UseCaseResponseMessage
    {
        public gen_residenttypeEntity _gen_ResidentType { get; }

        public IEnumerable<gen_residenttypeEntity> _gen_ResidentTypeList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ResidentTypeResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ResidentTypeResponse(IEnumerable<gen_residenttypeEntity> gen_ResidentTypeList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ResidentTypeList = gen_ResidentTypeList;
        }
        
        public Gen_ResidentTypeResponse(gen_residenttypeEntity gen_ResidentType, bool success = false, string message = null) : base(success, message)
        {
            _gen_ResidentType = gen_ResidentType;
        }

        public Gen_ResidentTypeResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
