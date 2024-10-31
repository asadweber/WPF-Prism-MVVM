using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BatchCandProfessionResponse : UseCaseResponseMessage
    {
        public gen_batchcandprofessionEntity _gen_BatchCandProfession { get; }

        public IEnumerable<gen_batchcandprofessionEntity> _gen_BatchCandProfessionList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BatchCandProfessionResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BatchCandProfessionResponse(IEnumerable<gen_batchcandprofessionEntity> gen_BatchCandProfessionList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandProfessionList = gen_BatchCandProfessionList;
        }
        
        public Gen_BatchCandProfessionResponse(gen_batchcandprofessionEntity gen_BatchCandProfession, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchCandProfession = gen_BatchCandProfession;
        }

        public Gen_BatchCandProfessionResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
