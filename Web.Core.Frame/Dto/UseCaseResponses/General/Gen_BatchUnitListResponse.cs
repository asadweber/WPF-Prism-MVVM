using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_BatchUnitListResponse : UseCaseResponseMessage
    {
        public gen_batchunitlistEntity _gen_BatchUnitList { get; }

        public IEnumerable<gen_batchunitlistEntity> _gen_BatchUnitListList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_BatchUnitListResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_BatchUnitListResponse(IEnumerable<gen_batchunitlistEntity> gen_BatchUnitListList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchUnitListList = gen_BatchUnitListList;
        }
        
        public Gen_BatchUnitListResponse(gen_batchunitlistEntity gen_BatchUnitList, bool success = false, string message = null) : base(success, message)
        {
            _gen_BatchUnitList = gen_BatchUnitList;
        }

        public Gen_BatchUnitListResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
