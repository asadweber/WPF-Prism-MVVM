using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_SMSActivationTransectionUseCase : IUseCaseRequestHandler<Cnf_SMSActivationTransectionRequest, Cnf_SMSActivationTransectionResponse>
    {
        Task<bool> Save(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);

        Task<bool> Update(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);

        Task<bool> Delete(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);


        Task<bool> GetSingle(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);

        Task<bool> GetAll(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);

        Task<bool> GetListView(Cnf_SMSActivationTransectionRequest message, ICRUDRequestHandler<Cnf_SMSActivationTransectionResponse> outputPort);



    }
}
