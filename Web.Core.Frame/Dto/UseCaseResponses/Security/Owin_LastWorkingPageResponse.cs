using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Owin_LastWorkingPageResponse : UseCaseResponseMessage
    {
        public owin_lastworkingpageEntity _owin_LastWorkingPage { get; }

        public IEnumerable<owin_lastworkingpageEntity> _owin_LastWorkingPageList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Owin_LastWorkingPageResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Owin_LastWorkingPageResponse(IEnumerable<owin_lastworkingpageEntity> owin_LastWorkingPageList, bool success = false, string message = null) : base(success, message)
        {
            _owin_LastWorkingPageList = owin_LastWorkingPageList;
        }
        
        public Owin_LastWorkingPageResponse(owin_lastworkingpageEntity owin_LastWorkingPage, bool success = false, string message = null) : base(success, message)
        {
            _owin_LastWorkingPage = owin_LastWorkingPage;
        }

        public Owin_LastWorkingPageResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
