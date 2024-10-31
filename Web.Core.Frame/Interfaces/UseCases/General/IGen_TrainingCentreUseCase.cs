using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_TrainingCentreUseCase : IUseCaseRequestHandler<Gen_TrainingCentreRequest, Gen_TrainingCentreResponse>
    {
        Task<bool> Save(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);

        Task<bool> Update(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);

        Task<bool> Delete(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);


        Task<bool> GetSingle(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);

        Task<bool> GetAll(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);


        Task<bool> GetAllPaged(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);

        Task<bool> GetListView(Gen_TrainingCentreRequest message, ICRUDRequestHandler<Gen_TrainingCentreResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_TrainingCentreRequest message, IDDLRequestHandler<Gen_TrainingCentreResponse> outputPort);
    
    }
}
