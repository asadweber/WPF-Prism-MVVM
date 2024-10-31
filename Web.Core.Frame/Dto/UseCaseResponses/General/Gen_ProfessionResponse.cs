using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_ProfessionResponse : UseCaseResponseMessage
    {
        public gen_professionEntity _gen_Profession { get; }

        public IEnumerable<gen_professionEntity> _gen_ProfessionList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_ProfessionResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_ProfessionResponse(IEnumerable<gen_professionEntity> gen_ProfessionList, bool success = false, string message = null) : base(success, message)
        {
            _gen_ProfessionList = gen_ProfessionList;
        }
        
        public Gen_ProfessionResponse(gen_professionEntity gen_Profession, bool success = false, string message = null) : base(success, message)
        {
            _gen_Profession = gen_Profession;
        }

        public Gen_ProfessionResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
