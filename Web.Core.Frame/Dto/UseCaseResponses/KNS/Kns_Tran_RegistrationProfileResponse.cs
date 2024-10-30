using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.DataAccessObjects.Report;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_Tran_RegistrationProfileResponse : UseCaseResponseMessage
    {
        public kns_tran_registrationprofileEntity _kns_TranRegistrationProfile { get; }


        public List<reg_studentprofilereportEntity> report { get; set; }

        public IEnumerable<kns_tran_registrationprofileEntity> _kns_TranRegistrationProfileList { get; }


        public IList<RecruitSituationReportEntity> _RecruitSituationReportEntity { get; }


        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_Tran_RegistrationProfileResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_Tran_RegistrationProfileResponse(IEnumerable<kns_tran_registrationprofileEntity> kns_TranRegistrationProfileList, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegistrationProfileList = kns_TranRegistrationProfileList;
        }
        
        public Kns_Tran_RegistrationProfileResponse(kns_tran_registrationprofileEntity kns_TranRegistrationProfile, bool success = false, string message = null) : base(success, message)
        {
            _kns_TranRegistrationProfile = kns_TranRegistrationProfile;
        }

        public Kns_Tran_RegistrationProfileResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }

        public Kns_Tran_RegistrationProfileResponse(IList<RecruitSituationReportEntity> RecruitSituationReportEntityList, bool success = false, string message = null) : base(success, message)
        {
            _RecruitSituationReportEntity = RecruitSituationReportEntityList;
        }



		public Kns_Tran_RegistrationProfileResponse(List<reg_studentprofilereportEntity> _report, bool success = false, string message = null) : base(success, message)
		{
			report = _report;
		}

	}
}
