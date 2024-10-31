using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_EducationMajorUseCase : IUseCaseRequestHandler<Gen_EducationMajorRequest, Gen_EducationMajorResponse>
    {
        Task<bool> Save(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);

        Task<bool> Update(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);

        Task<bool> Delete(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);


        Task<bool> GetSingle(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);

        Task<bool> GetAll(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);


        Task<bool> GetAllPaged(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);

        Task<bool> GetListView(Gen_EducationMajorRequest message, ICRUDRequestHandler<Gen_EducationMajorResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_EducationMajorRequest message, IDDLRequestHandler<Gen_EducationMajorResponse> outputPort);
    
    }
}
