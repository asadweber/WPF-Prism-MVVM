using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class Tran_ApplicantPhasesResponse : UseCaseResponseMessage
    {
        public tran_applicantphasesEntity _tran_ApplicantPhases { get; }

        public IEnumerable<tran_applicantphasesEntity> _tran_ApplicantPhasesList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_ApplicantPhasesResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_ApplicantPhasesResponse(IEnumerable<tran_applicantphasesEntity> tran_ApplicantPhasesList, bool success = false, string message = null) : base(success, message)
        {
            _tran_ApplicantPhasesList = tran_ApplicantPhasesList;
        }

        public Tran_ApplicantPhasesResponse(tran_applicantphasesEntity tran_ApplicantPhases, bool success = false, string message = null) : base(success, message)
        {
            _tran_ApplicantPhases = tran_ApplicantPhases;
        }

        public Tran_ApplicantPhasesResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
