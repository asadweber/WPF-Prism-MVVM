using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Transaction
{
    public partial class Tran_RollbackInfoResponse : UseCaseResponseMessage
    {
        public tran_rollbackinfoEntity _tran_RollbackInfo { get; }

        public IEnumerable<tran_rollbackinfoEntity> _tran_RollbackInfoList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Tran_RollbackInfoResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Tran_RollbackInfoResponse(IEnumerable<tran_rollbackinfoEntity> tran_RollbackInfoList, bool success = false, string message = null) : base(success, message)
        {
            _tran_RollbackInfoList = tran_RollbackInfoList;
        }

        public Tran_RollbackInfoResponse(tran_rollbackinfoEntity tran_RollbackInfo, bool success = false, string message = null) : base(success, message)
        {
            _tran_RollbackInfo = tran_RollbackInfo;
        }

        public Tran_RollbackInfoResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
