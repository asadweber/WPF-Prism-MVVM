using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Gen_LanguagesResponse : UseCaseResponseMessage
    {
        public gen_languagesEntity _gen_Languages { get; }

        public IEnumerable<gen_languagesEntity> _gen_LanguagesList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Gen_LanguagesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Gen_LanguagesResponse(IEnumerable<gen_languagesEntity> gen_LanguagesList, bool success = false, string message = null) : base(success, message)
        {
            _gen_LanguagesList = gen_LanguagesList;
        }
        
        public Gen_LanguagesResponse(gen_languagesEntity gen_Languages, bool success = false, string message = null) : base(success, message)
        {
            _gen_Languages = gen_Languages;
        }

        public Gen_LanguagesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
