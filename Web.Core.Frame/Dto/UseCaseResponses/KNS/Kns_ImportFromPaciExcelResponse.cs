using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Kns_ImportFromPaciExcelResponse : UseCaseResponseMessage
    {
        public kns_importfrompaciexcelEntity _kns_ImportFromPaciExcel { get; }

        public IEnumerable<kns_importfrompaciexcelEntity> _kns_ImportFromPaciExcelList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Kns_ImportFromPaciExcelResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Kns_ImportFromPaciExcelResponse(IEnumerable<kns_importfrompaciexcelEntity> kns_ImportFromPaciExcelList, bool success = false, string message = null) : base(success, message)
        {
            _kns_ImportFromPaciExcelList = kns_ImportFromPaciExcelList;
        }
        
        public Kns_ImportFromPaciExcelResponse(kns_importfrompaciexcelEntity kns_ImportFromPaciExcel, bool success = false, string message = null) : base(success, message)
        {
            _kns_ImportFromPaciExcel = kns_ImportFromPaciExcel;
        }

        public Kns_ImportFromPaciExcelResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }
        




    }
}
