using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IKns_StatusChangeRequestUseCase : IUseCaseRequestHandler<Kns_StatusChangeRequestRequest, Kns_StatusChangeRequestResponse>
    {
        Task<bool> Save(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        
        Task<bool> Update(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        Task<bool> UpdateDocumentVerificationStatusbyAdmin(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        Task<bool> Delete(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);


        Task<bool> GetSingle(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        Task<bool> GetSingleExt(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);

        Task<bool> GetAll(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);


        Task<bool> GetAllPaged(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);

        Task<bool> GetListView(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);
        
        Task<bool> GetListViewExt(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort, bool withButtonAction);

        Task<bool> GetListViewforDocumentVerification(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort, bool withButtonAction);
        Task<bool> GetAllApplicantRequest(Kns_StatusChangeRequestRequest message, IKns_StatusChangeRequestRequestHandler<Kns_StatusChangeRequestResponse> outputPort);

        Task<bool> ChangeStatusWithResulationByAdmin(Kns_StatusChangeRequestRequest message, ICRUDRequestHandler<Kns_StatusChangeRequestResponse> outputPort);

    }
}
