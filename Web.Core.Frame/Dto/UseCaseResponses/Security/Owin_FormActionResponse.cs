using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_FormActionResponse : UseCaseResponseMessage
    {
        public owin_formactionEntity _owin_FormAction { get; }

        public IEnumerable<owin_formactionEntity> _owin_FormActionList { get; }
        public IEnumerable<Owin_ProcessGetFormActionistEntity> _owin_ProcessFormActionList { get; }
        public IEnumerable<MenuWiseForm> _menuwiseform { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Owin_FormActionResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_FormActionResponse(IEnumerable<owin_formactionEntity> owin_FormActionList, bool success = false, string message = null) : base(success, message)
        {
            _owin_FormActionList = owin_FormActionList;
        }

        public Owin_FormActionResponse(owin_formactionEntity owin_FormAction, bool success = false, string message = null) : base(success, message)
        {
            _owin_FormAction = owin_FormAction;
        }
        public Owin_FormActionResponse(IEnumerable<Owin_ProcessGetFormActionistEntity> owin_ProcessFormActionList, bool success = false, string message = null) : base(success, message)
        {
            _owin_ProcessFormActionList = owin_ProcessFormActionList;
        }
        public Owin_FormActionResponse(IEnumerable<MenuWiseForm> MenuWiseFormList, bool success = false, string message = null) : base(success, message)
        {
            _menuwiseform = MenuWiseFormList;
        }
        public Owin_FormActionResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
