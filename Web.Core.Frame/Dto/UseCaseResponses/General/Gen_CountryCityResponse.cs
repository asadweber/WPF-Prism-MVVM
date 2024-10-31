using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CountryCityResponse : UseCaseResponseMessage
    {
        public gen_countrycityEntity _gen_CountryCity { get; }

        public IEnumerable<gen_countrycityEntity> _gen_CountryCityList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CountryCityResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CountryCityResponse(IEnumerable<gen_countrycityEntity> gen_CountryCityList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CountryCityList = gen_CountryCityList;
        }
        
        public Gen_CountryCityResponse(gen_countrycityEntity gen_CountryCity, bool success = false, string message = null) : base(success, message)
        {
            _gen_CountryCity = gen_CountryCity;
        }

        public Gen_CountryCityResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
