using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_SMSActivationCodeUseCase : IUseCaseRequestHandler<Cnf_SMSActivationCodeRequest, Cnf_SMSActivationCodeResponse>
    {
        Task<bool> Save(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);

        Task<bool> Update(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);

        Task<bool> Delete(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);


        Task<bool> GetSingle(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);

        Task<bool> GetAll(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);

        Task<bool> GetListView(Cnf_SMSActivationCodeRequest message, ICRUDRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);


        Task<bool> GetDataForDropDown(Cnf_SMSActivationCodeRequest message, IDDLRequestHandler<Cnf_SMSActivationCodeResponse> outputPort);

    }
}
