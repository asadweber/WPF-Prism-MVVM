using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_GeneralHealthResponse : UseCaseResponseMessage
    {
        public gen_generalhealthEntity _gen_GeneralHealth { get; }

        public IEnumerable<gen_generalhealthEntity> _gen_GeneralHealthList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_GeneralHealthResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_GeneralHealthResponse(IEnumerable<gen_generalhealthEntity> gen_GeneralHealthList, bool success = false, string message = null) : base(success, message)
        {
            _gen_GeneralHealthList = gen_GeneralHealthList;
        }
        
        public Gen_GeneralHealthResponse(gen_generalhealthEntity gen_GeneralHealth, bool success = false, string message = null) : base(success, message)
        {
            _gen_GeneralHealth = gen_GeneralHealth;
        }

        public Gen_GeneralHealthResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
