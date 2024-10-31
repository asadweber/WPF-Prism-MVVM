using BDO.Core.DataAccessObjects.ExtendedEntities;
using BDO.Core.DataAccessObjects.Models;
using BDO.Core.DataAccessObjects.SecurityModels;
using System.Collections.Generic;
using Web.Core.Frame.Dto;
using Web.Core.Frame.Interfaces;

namespace Web.Core.Frame.Dto.UseCaseResponses.Registration
{
    public partial class Reg_PreviousExperianceResponse : UseCaseResponseMessage
    {
        public reg_previousexperianceEntity _reg_PreviousExperiance { get; }

        public IEnumerable<reg_previousexperianceEntity> _reg_PreviousExperianceList { get; }

        public Error Errors { get; }

        public AjaxResponse _ajaxresponse { get; }



        public Reg_PreviousExperianceResponse(bool success = false, string message = null, Error errors = null) : base(success, message)
        {
            Errors = errors;
        }

        public Reg_PreviousExperianceResponse(IEnumerable<reg_previousexperianceEntity> reg_PreviousExperianceList, bool success = false, string message = null) : base(success, message)
        {
            _reg_PreviousExperianceList = reg_PreviousExperianceList;
        }

        public Reg_PreviousExperianceResponse(reg_previousexperianceEntity reg_PreviousExperiance, bool success = false, string message = null) : base(success, message)
        {
            _reg_PreviousExperiance = reg_PreviousExperiance;
        }

        public Reg_PreviousExperianceResponse(AjaxResponse ajaxresponse, bool success = false, string message = null) : base(success, message)
        {
            _ajaxresponse = ajaxresponse;
        }




    }
}
