using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_FormInfoResponse : UseCaseResponseMessage
    {
        public owin_forminfoEntity _owin_FormInfo { get; }

        public IEnumerable<owin_forminfoEntity> _owin_FormInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_FormInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_FormInfoResponse(IEnumerable<owin_forminfoEntity> owin_FormInfoList, bool success = false, string message = null) : base(success, message)
        {
            _owin_FormInfoList = owin_FormInfoList;
        }
        
        public Owin_FormInfoResponse(owin_forminfoEntity owin_FormInfo, bool success = false, string message = null) : base(success, message)
        {
            _owin_FormInfo = owin_FormInfo;
        }

        public Owin_FormInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
