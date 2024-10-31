using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_BasicInfoResponse : UseCaseResponseMessage
    {
        public reg_basicinfoEntity _reg_BasicInfo { get; }

        public IEnumerable<reg_basicinfoEntity> _reg_BasicInfoList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_BasicInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_BasicInfoResponse(IEnumerable<reg_basicinfoEntity> reg_BasicInfoList, bool success = false, string message = null) : base(success, message)
        {
            _reg_BasicInfoList = reg_BasicInfoList;
        }

        public Reg_BasicInfoResponse(reg_basicinfoEntity reg_BasicInfo, bool success = false, string message = null) : base(success, message)
        {
            _reg_BasicInfo = reg_BasicInfo;
        }

        public Reg_BasicInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
