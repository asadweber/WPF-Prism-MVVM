using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IOwin_UserPrefferencesSettingsUseCase : IUseCaseRequestHandler<Owin_UserPrefferencesSettingsRequest, Owin_UserPrefferencesSettingsResponse>
    {
        Task<bool> Save(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);

        Task<bool> Update(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);

        Task<bool> Delete(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);


        Task<bool> GetSingle(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);

        Task<bool> GetAll(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);


        Task<bool> GetAllPaged(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);

        Task<bool> GetListView(Owin_UserPrefferencesSettingsRequest message, ICRUDRequestHandler<Owin_UserPrefferencesSettingsResponse> outputPort);
    }
}
