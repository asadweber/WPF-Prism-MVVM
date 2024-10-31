using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_SkillProficiencyUseCase : IUseCaseRequestHandler<Gen_SkillProficiencyRequest, Gen_SkillProficiencyResponse>
    {
        Task<bool> Save(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);

        Task<bool> Update(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);

        Task<bool> Delete(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);


        Task<bool> GetSingle(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);

        Task<bool> GetAll(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);


        Task<bool> GetAllPaged(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);

        Task<bool> GetListView(Gen_SkillProficiencyRequest message, ICRUDRequestHandler<Gen_SkillProficiencyResponse> outputPort);
        
        
        		Task<bool> GetDataForDropDown(Gen_SkillProficiencyRequest message, IDDLRequestHandler<Gen_SkillProficiencyResponse> outputPort);
    
    }
}
