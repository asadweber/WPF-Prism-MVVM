using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
	public partial interface IKns_BatchDetailUseCase : IUseCaseRequestHandler<Kns_BatchDetailRequest, Kns_BatchDetailResponse>
	{
		Task<bool> Save(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

		Task<bool> Update(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

		Task<bool> Delete(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);


		Task<bool> GetSingle(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

		Task<bool> GetAll(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

		Task<bool> RecruitSummaryBatchReport(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);


		Task<bool> GetAllPaged(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

		Task<bool> GetListView(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);
		Task<bool> RecruitDetailsBatchReport(Kns_BatchDetailRequest message, ICRUDRequestHandler<Kns_BatchDetailResponse> outputPort);

		Task<bool> GetDataForDropDown(Kns_BatchDetailRequest message, IDDLRequestHandler<Kns_BatchDetailResponse> outputPort);




    }
}
