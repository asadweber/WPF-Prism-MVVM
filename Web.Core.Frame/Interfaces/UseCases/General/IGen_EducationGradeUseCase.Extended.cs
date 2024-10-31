using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_EducationGradeUseCase : IUseCaseRequestHandler<Gen_EducationGradeRequest, Gen_EducationGradeResponse>
    {
        Task<bool> GetEducationGradeDataForDropDown(Gen_EducationGradeRequest message, IDDLRequestHandler<Gen_EducationGradeResponse> outputPort);
    }
}
