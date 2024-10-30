using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.RequestResponse.UseCaseResponses
{
    public partial class Tran_RecievePaciDataInfoResponse : UseCaseResponseMessage
    {
        public tran_recievepacidatainfoEntity _tran_RecievePaciDataInfo { get; }

        public IEnumerable<tran_recievepacidatainfoEntity> _tran_RecievePaciDataInfoList { get; }

        public Error Errors { get; }
        
        public AjaxResponse _ajaxresponse { get; }
        
        
        
        public Tran_RecievePaciDataInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_RecievePaciDataInfoResponse(IEnumerable<tran_recievepacidatainfoEntity> tran_RecievePaciDataInfoList, bool success = false, string message = null) : base(success, message)
        {
            _tran_RecievePaciDataInfoList = tran_RecievePaciDataInfoList;
        }
        
        public Tran_RecievePaciDataInfoResponse(tran_recievepacidatainfoEntity tran_RecievePaciDataInfo, bool success = false, string message = null) : base(success, message)
        {
            _tran_RecievePaciDataInfo = tran_RecievePaciDataInfo;
        }

        public Tran_RecievePaciDataInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
