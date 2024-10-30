using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_Search_ParametersResponse : UseCaseResponseMessage
    {
        public gen_search_parametersEntity _gen_SearchParameters { get; }

        public IEnumerable<gen_search_parametersEntity> _gen_SearchParametersList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_Search_ParametersResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_Search_ParametersResponse(IEnumerable<gen_search_parametersEntity> gen_SearchParametersList, bool success = false, string message = null) : base(success, message)
        {
            _gen_SearchParametersList = gen_SearchParametersList;
        }
        
        public Gen_Search_ParametersResponse(gen_search_parametersEntity gen_SearchParameters, bool success = false, string message = null) : base(success, message)
        {
            _gen_SearchParameters = gen_SearchParameters;
        }

        public Gen_Search_ParametersResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
