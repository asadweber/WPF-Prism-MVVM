using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_DataCheckedResponse : UseCaseResponseMessage
    {
        public reg_datacheckedEntity _reg_DataChecked { get; }

        public IEnumerable<reg_datacheckedEntity> _reg_DataCheckedList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_DataCheckedResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_DataCheckedResponse(IEnumerable<reg_datacheckedEntity> reg_DataCheckedList, bool success = false, string message = null) : base(success, message)
        {
            _reg_DataCheckedList = reg_DataCheckedList;
        }

        public Reg_DataCheckedResponse(reg_datacheckedEntity reg_DataChecked, bool success = false, string message = null) : base(success, message)
        {
            _reg_DataChecked = reg_DataChecked;
        }

        public Reg_DataCheckedResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
