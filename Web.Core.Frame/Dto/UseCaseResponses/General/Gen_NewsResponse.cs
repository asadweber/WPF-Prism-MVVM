using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_NewsResponse : UseCaseResponseMessage
    {
        public gen_newsEntity _gen_News { get; }

        public IEnumerable<gen_newsEntity> _gen_NewsList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_NewsResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_NewsResponse(IEnumerable<gen_newsEntity> gen_NewsList, bool success = false, string message = null) : base(success, message)
        {
            _gen_NewsList = gen_NewsList;
        }
        
        public Gen_NewsResponse(gen_newsEntity gen_News, bool success = false, string message = null) : base(success, message)
        {
            _gen_News = gen_News;
        }

        public Gen_NewsResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
