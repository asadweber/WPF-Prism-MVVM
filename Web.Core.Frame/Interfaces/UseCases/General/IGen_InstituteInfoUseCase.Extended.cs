using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_InstituteInfoUseCase : IUseCaseRequestHandler<Gen_InstituteInfoRequest, Gen_InstituteInfoResponse>
    {
        Task<bool> GetListViewExt(Gen_InstituteInfoRequest message, ICRUDRequestHandler<Gen_InstituteInfoResponse> outputPort);
        Task<bool> GetInstituteInfoDataForDropDown(Gen_InstituteInfoRequest message, IDDLRequestHandler<Gen_InstituteInfoResponse> outputPort);
    }
}
