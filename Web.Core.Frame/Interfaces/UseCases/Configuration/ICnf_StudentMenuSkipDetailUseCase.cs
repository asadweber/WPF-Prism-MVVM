using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_StudentMenuSkipDetailUseCase : IUseCaseRequestHandler<Cnf_StudentMenuSkipDetailRequest, Cnf_StudentMenuSkipDetailResponse>
    {
        Task<bool> Save(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);

        Task<bool> Update(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);

        Task<bool> Delete(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);


        Task<bool> GetSingle(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);

        Task<bool> GetAll(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);

        Task<bool> GetListView(Cnf_StudentMenuSkipDetailRequest message, ICRUDRequestHandler<Cnf_StudentMenuSkipDetailResponse> outputPort);



    }
}
