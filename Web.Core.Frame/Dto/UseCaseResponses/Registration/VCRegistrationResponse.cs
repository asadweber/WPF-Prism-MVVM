using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public class VCRegistrationResponse : UseCaseResponseMessage
    {
        public RegistrationViewModel RegistrationViewModel { get; set; }

        public ProfileReportEntity ProfileReportModel { get; set; }
        public Reg_ApplicantDataCheckedEntity Reg_ApplicantDataCheckedModel { get; set; }

        public reg_basicinfoEntity _reg_BasicInfo { get; set;}

        public IEnumerable<reg_basicinfoEntity> _reg_BasicInfoList { get; set; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public VCRegistrationResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }
        public VCRegistrationResponse(IEnumerable<reg_basicinfoEntity> reg_BasicInfoList, bool success = false, string message = null) : base(success, message)
        {
            _reg_BasicInfoList = reg_BasicInfoList;
        }

        public VCRegistrationResponse(reg_basicinfoEntity reg_BasicInfo, bool success = false, string message = null) : base(success, message)
        {
            _reg_BasicInfo = reg_BasicInfo;
        }



        public VCRegistrationResponse(RegistrationViewModel registrationviewmodel, bool success = false, string message = null) : base(success, message)
        {
            RegistrationViewModel = registrationviewmodel;
        }


        public VCRegistrationResponse(ProfileReportEntity registrationviewmodel, bool success = false, string message = null) : base(success, message)
        {
            ProfileReportModel = registrationviewmodel;
        }

        public VCRegistrationResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }

        public VCRegistrationResponse(Error errors,AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
            Errors = errors;
        }

        public VCRegistrationResponse(Reg_ApplicantDataCheckedEntity _reg_applicantdatacheckedmodel, bool success = false, string message = null) : base(success, message)
        {
            Reg_ApplicantDataCheckedModel = _reg_applicantdatacheckedmodel;
        }

    }
}
