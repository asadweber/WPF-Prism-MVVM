using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_StudentMenuSkipUseCase : IUseCaseRequestHandler<Cnf_StudentMenuSkipRequest, Cnf_StudentMenuSkipResponse>
    {
        Task<bool> Save(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);

        Task<bool> Update(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);

        Task<bool> Delete(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);


        Task<bool> GetSingle(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);

        Task<bool> GetAll(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);

        Task<bool> GetListView(Cnf_StudentMenuSkipRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);


        Task<bool> GetDataForDropDown(Cnf_StudentMenuSkipRequest message, IDDLRequestHandler<Cnf_StudentMenuSkipResponse> outputPort);

    }
}
