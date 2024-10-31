using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Registration;
using Web.Core.Frame.Dto.UseCaseResponses.Registration;

namespace Web.Core.Frame.Interfaces.UseCases.Registration
{
    public partial interface IReg_LanguageUseCase : IUseCaseRequestHandler<Reg_LanguageRequest, Reg_LanguageResponse>
    {
        Task<bool> Save(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);

        Task<bool> Update(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);

        Task<bool> Delete(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);


        Task<bool> GetSingle(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);

        Task<bool> GetAll(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);


        Task<bool> GetAllPaged(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);

        Task<bool> GetListView(Reg_LanguageRequest message, ICRUDRequestHandler<Reg_LanguageResponse> outputPort);



    }
}
