using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using BDO.DataAccessObjects.ChartModel;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_BatchDetailResponse : UseCaseResponseMessage
    {

        public RegisteredStatisticsChartEntity _RegisteredStatisticsChartEntity { get; }
        public Kns_BatchDetailResponse(RegisteredStatisticsChartEntity kns_BatchDetail, bool success = false, string message = null) : base(success, message)
        {
            _RegisteredStatisticsChartEntity = kns_BatchDetail;
        }

       




    }
}
