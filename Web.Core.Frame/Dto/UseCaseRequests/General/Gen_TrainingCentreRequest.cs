using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_TrainingCentreRequest : IUseCaseRequest<Gen_TrainingCentreResponse>
    {
        public gen_trainingcentreEntity Objgen_trainingcentre { get; }
        
        public Gen_TrainingCentreRequest(gen_trainingcentreEntity objgen_trainingcentre)
        {
            Objgen_trainingcentre = objgen_trainingcentre;
        }
    }
}
