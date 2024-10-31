using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseRequests.Transaction;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces.UseCases.Transaction
{
    public partial interface IVCApplicantReviewUseCase : IUseCaseRequestHandler<VCApplicantReviewRequest, VCApplicantReviewResponse>
    {
        Task<bool> GetApplicantDetailsByRegistrationIDForReview(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort);
        Task<bool> GetRegistrationByBasicInfoId(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort);
        Task<bool> ValidateMobileNumber(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort);
        Task<bool> ValidateEmailAddress(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort);
        Task<bool> SaveApplicantReviewBasicInfo(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort);
        Task<bool> SaveDocument(VCApplicantReviewRequest message, IVCApplicantReviewRequestHandler<VCApplicantReviewResponse> outputPort);
    }
}
