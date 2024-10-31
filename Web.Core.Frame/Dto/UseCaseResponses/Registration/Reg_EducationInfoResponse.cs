using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_EducationInfoResponse : UseCaseResponseMessage
    {
        public reg_educationinfoEntity _reg_EducationInfo { get; }

        public IEnumerable<reg_educationinfoEntity> _reg_EducationInfoList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_EducationInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_EducationInfoResponse(IEnumerable<reg_educationinfoEntity> reg_EducationInfoList, bool success = false, string message = null) : base(success, message)
        {
            _reg_EducationInfoList = reg_EducationInfoList;
        }

        public Reg_EducationInfoResponse(reg_educationinfoEntity reg_EducationInfo, bool success = false, string message = null) : base(success, message)
        {
            _reg_EducationInfo = reg_EducationInfo;
        }

        public Reg_EducationInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
