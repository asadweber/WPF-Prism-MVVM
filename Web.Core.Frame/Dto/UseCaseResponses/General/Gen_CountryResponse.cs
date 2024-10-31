using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CountryResponse : UseCaseResponseMessage
    {
        public gen_countryEntity _gen_Country { get; }

        public IEnumerable<gen_countryEntity> _gen_CountryList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CountryResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CountryResponse(IEnumerable<gen_countryEntity> gen_CountryList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CountryList = gen_CountryList;
        }
        
        public Gen_CountryResponse(gen_countryEntity gen_Country, bool success = false, string message = null) : base(success, message)
        {
            _gen_Country = gen_Country;
        }

        public Gen_CountryResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
