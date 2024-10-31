using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.DataAccessObjects.VCRegistration;
using BDO.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class VCApplicantReviewResponse : UseCaseResponseMessage
    {

        public ApplicantReviewViewModel ApplicantReviewViewModel { get; set; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public VCApplicantReviewResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public VCApplicantReviewResponse(ApplicantReviewViewModel applicantreviewviewmodel, bool success = false, string message = null) : base(success, message)
        {
            ApplicantReviewViewModel = applicantreviewviewmodel;
        }

        public VCApplicantReviewResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }

        public VCApplicantReviewResponse(Error errors, AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
            Errors = errors;
        }

    }
}
