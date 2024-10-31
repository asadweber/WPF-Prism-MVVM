using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_FamillyResponse : UseCaseResponseMessage
    {
        public reg_famillyEntity _reg_Familly { get; }

        public IEnumerable<reg_famillyEntity> _reg_FamillyList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_FamillyResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_FamillyResponse(IEnumerable<reg_famillyEntity> reg_FamillyList, bool success = false, string message = null) : base(success, message)
        {
            _reg_FamillyList = reg_FamillyList;
        }

        public Reg_FamillyResponse(reg_famillyEntity reg_Familly, bool success = false, string message = null) : base(success, message)
        {
            _reg_Familly = reg_Familly;
        }

        public Reg_FamillyResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
