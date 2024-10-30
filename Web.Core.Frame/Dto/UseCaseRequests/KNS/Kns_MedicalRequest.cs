using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Kns_MedicalRequest : IUseCaseRequest<Kns_MedicalResponse>
    {
        public kns_medicalEntity Objkns_medical { get; }
        
        public Kns_MedicalRequest(kns_medicalEntity objkns_medical)
        {
            Objkns_medical = objkns_medical;
        }
    }
}
