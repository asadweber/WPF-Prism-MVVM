using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_RelativesWorkingInMODResponse : UseCaseResponseMessage
    {
        public reg_relativesworkinginmodEntity _reg_RelativesWorkingInMOD { get; }

        public IEnumerable<reg_relativesworkinginmodEntity> _reg_RelativesWorkingInMODList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_RelativesWorkingInMODResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_RelativesWorkingInMODResponse(IEnumerable<reg_relativesworkinginmodEntity> reg_RelativesWorkingInMODList, bool success = false, string message = null) : base(success, message)
        {
            _reg_RelativesWorkingInMODList = reg_RelativesWorkingInMODList;
        }

        public Reg_RelativesWorkingInMODResponse(reg_relativesworkinginmodEntity reg_RelativesWorkingInMOD, bool success = false, string message = null) : base(success, message)
        {
            _reg_RelativesWorkingInMOD = reg_RelativesWorkingInMOD;
        }

        public Reg_RelativesWorkingInMODResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
