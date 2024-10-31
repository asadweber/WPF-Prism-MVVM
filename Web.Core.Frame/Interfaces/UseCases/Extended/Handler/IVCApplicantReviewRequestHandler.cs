using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Transaction;

namespace Web.Core.Frame.Interfaces
{
    public interface IVCApplicantReviewRequestHandler<in TUseCaseResponse>
    {
        void GetApplicantDetailsForReview(VCApplicantReviewResponse response);

        void GetRegisteredApplicantProfileDataByBasicInfoId(VCApplicantReviewResponse response);

        void ValidationPolicy(TUseCaseResponse response);

        void SaveApplicantReviewData(TUseCaseResponse response);

        void SaveDocument(VCApplicantReviewResponse response);

    }
}