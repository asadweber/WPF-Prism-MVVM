using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class KNS_ApiMigrateDataInfoResponse : UseCaseResponseMessage
    {
        public kns_apimigrateProcessStatistics _ProcessStatistics { get; }
        public kns_apimigratedatainfoEntity _kns_ApiMigrateDataInfo { get; }

        public IEnumerable<kns_apimigratedatainfoEntity> _kns_ApiMigrateDataInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public KNS_ApiMigrateDataInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public KNS_ApiMigrateDataInfoResponse(IEnumerable<kns_apimigratedatainfoEntity> kns_ApiMigrateDataInfoList, bool success = false, string message = null) : base(success, message)
        {
            _kns_ApiMigrateDataInfoList = kns_ApiMigrateDataInfoList;
        }
        
        public KNS_ApiMigrateDataInfoResponse(kns_apimigratedatainfoEntity kns_ApiMigrateDataInfo, bool success = false, string message = null) : base(success, message)
        {
            _kns_ApiMigrateDataInfo = kns_ApiMigrateDataInfo;
        }


        public KNS_ApiMigrateDataInfoResponse(kns_apimigrateProcessStatistics ProcessStatistics, bool success = false, string message = null) : base(success, message)
        {
            _ProcessStatistics = ProcessStatistics;
        }

        public KNS_ApiMigrateDataInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
