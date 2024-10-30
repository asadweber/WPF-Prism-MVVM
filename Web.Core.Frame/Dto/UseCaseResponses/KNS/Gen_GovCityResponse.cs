using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_GovCityResponse : UseCaseResponseMessage
    {
        public gen_govcityEntity _gen_GovCity { get; }

        public IEnumerable<gen_govcityEntity> _gen_GovCityList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_GovCityResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_GovCityResponse(IEnumerable<gen_govcityEntity> gen_GovCityList, bool success = false, string message = null) : base(success, message)
        {
            _gen_GovCityList = gen_GovCityList;
        }
        
        public Gen_GovCityResponse(gen_govcityEntity gen_GovCity, bool success = false, string message = null) : base(success, message)
        {
            _gen_GovCity = gen_GovCity;
        }

        public Gen_GovCityResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
