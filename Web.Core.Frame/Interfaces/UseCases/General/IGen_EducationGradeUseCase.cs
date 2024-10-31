using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_EducationGradeUseCase : IUseCaseRequestHandler<Gen_EducationGradeRequest, Gen_EducationGradeResponse>
    {
        Task<bool> Save(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);

        Task<bool> Update(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);

        Task<bool> Delete(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);


        Task<bool> GetSingle(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);

        Task<bool> GetAll(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);


        Task<bool> GetAllPaged(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);

        Task<bool> GetListView(Gen_EducationGradeRequest message, ICRUDRequestHandler<Gen_EducationGradeResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_EducationGradeRequest message, IDDLRequestHandler<Gen_EducationGradeResponse> outputPort);
    
    }
}
