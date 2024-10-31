using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;

namespace Web.Core.Frame.Interfaces.UseCases.Configuration
{
    public partial interface ICnf_FileRequiredUseCase : IUseCaseRequestHandler<Cnf_FileRequiredRequest, Cnf_FileRequiredResponse>
    {
        Task<bool> Save(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);

        Task<bool> Update(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);

        Task<bool> Delete(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);


        Task<bool> GetSingle(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);

        Task<bool> GetAll(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);

        Task<bool> GetListView(Cnf_FileRequiredRequest message, ICRUDRequestHandler<Cnf_FileRequiredResponse> outputPort);


        Task<bool> GetDataForDropDown(Cnf_FileRequiredRequest message, IDDLRequestHandler<Cnf_FileRequiredResponse> outputPort);

    }
}
