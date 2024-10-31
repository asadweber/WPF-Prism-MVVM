using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class Gen_BatchCandProfessionRequest : IUseCaseRequest<Gen_BatchCandProfessionResponse>
    {
        public gen_batchcandprofessionEntity Objgen_batchcandprofession { get; }

        public List<gen_batchcandprofessionEntity> Objgen_batchcandprofessionList { get; }


        public Gen_BatchCandProfessionRequest(gen_batchcandprofessionEntity objgen_batchcandprofession)
        {
            Objgen_batchcandprofession = objgen_batchcandprofession;
        }

        public Gen_BatchCandProfessionRequest(List<gen_batchcandprofessionEntity> objgen_batchcandprofessionList)
        {
            Objgen_batchcandprofessionList = objgen_batchcandprofessionList;
        }
    }
}
