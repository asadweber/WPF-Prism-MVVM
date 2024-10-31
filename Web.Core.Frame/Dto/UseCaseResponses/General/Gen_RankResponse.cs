using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_RankResponse : UseCaseResponseMessage
    {
        public gen_rankEntity _gen_Rank { get; }

        public IEnumerable<gen_rankEntity> _gen_RankList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_RankResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_RankResponse(IEnumerable<gen_rankEntity> gen_RankList, bool success = false, string message = null) : base(success, message)
        {
            _gen_RankList = gen_RankList;
        }
        
        public Gen_RankResponse(gen_rankEntity gen_Rank, bool success = false, string message = null) : base(success, message)
        {
            _gen_Rank = gen_Rank;
        }

        public Gen_RankResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
