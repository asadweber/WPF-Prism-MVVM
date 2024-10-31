using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_PunishmentResponse : UseCaseResponseMessage
    {
        public reg_punishmentEntity _reg_Punishment { get; }

        public IEnumerable<reg_punishmentEntity> _reg_PunishmentList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_PunishmentResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_PunishmentResponse(IEnumerable<reg_punishmentEntity> reg_PunishmentList, bool success = false, string message = null) : base(success, message)
        {
            _reg_PunishmentList = reg_PunishmentList;
        }

        public Reg_PunishmentResponse(reg_punishmentEntity reg_Punishment, bool success = false, string message = null) : base(success, message)
        {
            _reg_Punishment = reg_Punishment;
        }

        public Reg_PunishmentResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
