using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_LanguageResponse : UseCaseResponseMessage
    {
        public reg_languageEntity _reg_Language { get; }

        public IEnumerable<reg_languageEntity> _reg_LanguageList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_LanguageResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_LanguageResponse(IEnumerable<reg_languageEntity> reg_LanguageList, bool success = false, string message = null) : base(success, message)
        {
            _reg_LanguageList = reg_LanguageList;
        }

        public Reg_LanguageResponse(reg_languageEntity reg_Language, bool success = false, string message = null) : base(success, message)
        {
            _reg_Language = reg_Language;
        }

        public Reg_LanguageResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
