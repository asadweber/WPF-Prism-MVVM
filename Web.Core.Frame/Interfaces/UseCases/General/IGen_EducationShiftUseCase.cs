using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_EducationShiftUseCase : IUseCaseRequestHandler<Gen_EducationShiftRequest, Gen_EducationShiftResponse>
    {
        Task<bool> Save(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);

        Task<bool> Update(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);

        Task<bool> Delete(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);


        Task<bool> GetSingle(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);

        Task<bool> GetAll(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);


        Task<bool> GetAllPaged(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);

        Task<bool> GetListView(Gen_EducationShiftRequest message, ICRUDRequestHandler<Gen_EducationShiftResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_EducationShiftRequest message, IDDLRequestHandler<Gen_EducationShiftResponse> outputPort);
    
    }
}
