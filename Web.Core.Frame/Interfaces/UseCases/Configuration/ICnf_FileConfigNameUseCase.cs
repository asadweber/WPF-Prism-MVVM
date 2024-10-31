using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests.Configuration;
using Web.Core.Frame.Dto.UseCaseResponses.Configuration;
using Web.Core.Frame.Presenters;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface ICnf_FileConfigNameUseCase : IUseCaseRequestHandler<Cnf_FileConfigNameRequest, Cnf_FileConfigNameResponse>
    {
        Task<bool> Save(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);

        Task<bool> Update(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);

        Task<bool> Delete(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);


        Task<bool> GetSingle(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);

        Task<bool> GetAll(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);


        Task<bool> GetAllPaged(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);

        Task<bool> GetListView(Cnf_FileConfigNameRequest message, ICRUDRequestHandler<Cnf_FileConfigNameResponse> outputPort);

        Task<bool> GetDataForDropDown(Cnf_FileConfigNameRequest message, IDDLRequestHandler<Cnf_FileConfigNameResponse> outputPort);
    }
}
