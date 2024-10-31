using System.Threading.Tasks;
using Web.Core.Frame.RequestResponse.UseCaseRequests;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.Interfaces.UseCases
{
    public partial interface IGen_CountryUseCase : IUseCaseRequestHandler<Gen_CountryRequest, Gen_CountryResponse>
    {
        Task<bool> GetCountryByCandidateTypeDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetSingleByCountryId(Gen_CountryRequest message, ICRUDRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetQualificationCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetPlaceOfBirthCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetFatherNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetMotherNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetNationalityForDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);
        Task<bool> GetGenericNationalityCountryDropDown(Gen_CountryRequest message, IDDLRequestHandler<Gen_CountryResponse> outputPort);

    }
}