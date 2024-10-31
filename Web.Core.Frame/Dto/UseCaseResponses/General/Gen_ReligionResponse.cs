using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ReligionResponse : UseCaseResponseMessage
    {
        public gen_religionEntity _gen_Religion { get; }

        public IEnumerable<gen_religionEntity> _gen_ReligionList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ReligionResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ReligionResponse(IEnumerable<gen_religionEntity> gen_ReligionList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ReligionList = gen_ReligionList;
        }
        
        public Gen_ReligionResponse(gen_religionEntity gen_Religion, bool success = false, string message = null) : base(success, message)
        {
            _gen_Religion = gen_Religion;
        }

        public Gen_ReligionResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
