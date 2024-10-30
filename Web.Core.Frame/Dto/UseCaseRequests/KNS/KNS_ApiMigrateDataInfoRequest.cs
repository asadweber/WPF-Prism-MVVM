using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Interfaces;
using Web.Core.Frame.RequestResponse.UseCaseResponses;

namespace Web.Core.Frame.RequestResponse.UseCaseRequests
{
    public partial class KNS_ApiMigrateDataInfoRequest : IUseCaseRequest<KNS_ApiMigrateDataInfoResponse>
    {
        public kns_apimigratedatainfoEntity Objkns_apimigratedatainfo { get; }
        public List<kns_apimigratedatainfoEntity> Objkns_apimigratedatainfoList { get; }

        public KNS_ApiMigrateDataInfoRequest(kns_apimigratedatainfoEntity objkns_apimigratedatainfo)
        {
            Objkns_apimigratedatainfo = objkns_apimigratedatainfo;
        }
        public KNS_ApiMigrateDataInfoRequest(List<kns_apimigratedatainfoEntity> objkns_apimigratedatainfo)
        {
            Objkns_apimigratedatainfoList = objkns_apimigratedatainfo;
        }
    }
}
