using BDO.Core.DataAccessObjects.CommonEntities;
using BDO.DataAccessObjects.VCApplicantReview;
using BDO.DataAccessObjects.VCRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseRequests.Transaction
{
    public partial class VCApplicantReviewRequest : IUseCaseRequest<VCApplicantReviewResponse>
    {
        public long? RegistrationID { get; set; }
        public long? BasicInfoID { get; set; }
        public long? ApplicantTableID { get; set; }
        public PreRegistrationValidationParameters validationParameter { get; set; }
        public ApplicantReviewViewModel applicantreviewViewModel { get; set; }
        public VCApplicantReviewRequest() { 
        
        }

    }
}
