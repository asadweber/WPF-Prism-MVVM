using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_CountryClassResponse : UseCaseResponseMessage
    {
        public gen_countryclassEntity _gen_CountryClass { get; }

        public IEnumerable<gen_countryclassEntity> _gen_CountryClassList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_CountryClassResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_CountryClassResponse(IEnumerable<gen_countryclassEntity> gen_CountryClassList, bool success = false, string message = null) : base(success, message)
        {
            _gen_CountryClassList = gen_CountryClassList;
        }
        
        public Gen_CountryClassResponse(gen_countryclassEntity gen_CountryClass, bool success = false, string message = null) : base(success, message)
        {
            _gen_CountryClass = gen_CountryClass;
        }

        public Gen_CountryClassResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
