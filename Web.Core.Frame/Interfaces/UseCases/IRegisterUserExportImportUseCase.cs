using System.Threading.Tasks;
using Web.Core.Frame.Dto.UseCaseRequests;
using Web.Core.Frame.Dto.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
   public interface IRegisterUserExportImportUseCase : IUseCaseRequestHandler<RegisterUserExportImportRequest, RegisterUserExportImportResponse>
   {
        Task<bool> Export(RegisterUserExportImportRequest message, IRegisterUserExportImportRequestHandler<RegisterUserExportImportResponse> outputPort);
        Task<bool> Import(RegisterUserExportImportRequest message, IRegisterUserExportImportRequestHandler<RegisterUserExportImportResponse> outputPort);

		Task<bool> GetAllBatch(IRegisterUserExportImportRequestHandler<RegisterUserExportImportResponse> outputPort);

	}
}
