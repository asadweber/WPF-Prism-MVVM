using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_NonKuwaityStatusResponse : UseCaseResponseMessage
    {
        public reg_nonkuwaitystatusEntity _reg_NonKuwaityStatus { get; }

        public IEnumerable<reg_nonkuwaitystatusEntity> _reg_NonKuwaityStatusList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_NonKuwaityStatusResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_NonKuwaityStatusResponse(IEnumerable<reg_nonkuwaitystatusEntity> reg_NonKuwaityStatusList, bool success = false, string message = null) : base(success, message)
        {
            _reg_NonKuwaityStatusList = reg_NonKuwaityStatusList;
        }

        public Reg_NonKuwaityStatusResponse(reg_nonkuwaitystatusEntity reg_NonKuwaityStatus, bool success = false, string message = null) : base(success, message)
        {
            _reg_NonKuwaityStatus = reg_NonKuwaityStatus;
        }

        public Reg_NonKuwaityStatusResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
